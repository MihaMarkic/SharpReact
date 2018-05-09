using SharpReact.Core.Properties;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SharpReact.Core
{
    public abstract class SharpRenderer<TElement>: ISharpRenderer
    {
        private SharpProp previous;
        public TElement Parent { get;  }
        private readonly Func<SharpProp> createTree;
        private bool isInvalidated;
        private TaskScheduler uiScheduler;
        public SharpRenderer(Func<SharpProp> createTree, TElement parent)
        {
            this.uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            this.createTree = createTree;
            Parent = parent;
        }
        public void Invalidate(NewState newState)
        {
            if (!isInvalidated)
            {
                isInvalidated = true;
                try
                {
                    Render(newState);
                    isInvalidated = false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"ooops {ex.Message}");
                }
            }
        }
        public void Render(NewState newState)
        {
            var root = createTree();
            var current = UpdateTree(newState, root);
            previous = root;
        }
        public void Redraw()
        {
            Render(NewState.Empty);
        }
        public TElement UpdateTree(NewState newState, SharpProp current)
        {
            return VisitAll(0, newState, Parent, previous, current);
        }

        protected abstract void Attach(TElement parent, TElement child);
        protected abstract void Detach(TElement parent, TElement child);

        public (ISharpStatefulComponent Stateful, ISharpNativeComponent Native) CreateNewComponent(TElement nativeRoot, ISharpProp current)
        {
            current.Init();
            var statefulComponent = current.Component;
            statefulComponent.Renderer = this;
            statefulComponent.WillMount();
            var nativeCurrent = statefulComponent as ISharpNativeComponent;
            if (nativeCurrent != null)
            {
                Attach(nativeRoot, (TElement)nativeCurrent.Element);
            }
            statefulComponent.DidMount();
            return (statefulComponent, nativeCurrent);
        }

        public static void DestroyBranch(ISharpProp root)
        {
            if (ReferenceEquals(root, null))
            {
                return;
            }
            root.Component.WillUnmount();
            if (root is SharpNativeProp)
            {
                if (root is IContainer container)
                {
                    DestroyBranch(container.Content);
                }
                else if (root is IChildrenContainer childrenContainer)
                {
                    foreach (var child in childrenContainer.Children)
                    {
                        DestroyBranch(child);
                    }
                }
            }
            else if (root is ISharpCompositeProp composite)
            {
                DestroyBranch(composite.Generated);
            }
        }

        public static void UpdateComponent(ISharpProp current, ISharpStatefulComponent statefulComponent, object newComponentState)
        {
            statefulComponent.WillReceiveProps(current);
            statefulComponent.AssignProperties(current);
            statefulComponent.DidUpdate(current, newComponentState);
        }

        public TElement ProcessPair(int level, NewState newState, TElement nativeRoot, ISharpProp previous, ISharpProp current)
        {
            if (ReferenceEquals(current, null))
            {
                return default(TElement);
            }
            ISharpStatefulComponent statefulComponent;
            ISharpNativeComponent nativeCurrent;
            // this can be reset to null if old branch gets deleted
            ISharpProp currentPrevious = previous;
            if (ReferenceEquals(currentPrevious, null))
            {
                (statefulComponent, nativeCurrent) = CreateNewComponent(nativeRoot, current);
            }
            else if (currentPrevious.GetType() != current.GetType())
            {
                DestroyBranch(currentPrevious);
                Detach(nativeRoot, (TElement)currentPrevious.Component.Element);
                currentPrevious = null;
                (statefulComponent, nativeCurrent) = CreateNewComponent(nativeRoot, current);
            }
            else
            {
                statefulComponent = currentPrevious.Component;
                current.Transfer(statefulComponent);
                nativeCurrent = statefulComponent as ISharpNativeComponent;
            }
            // new state is assigned if matching
            object newComponentState = newState.Props == currentPrevious ? newState.State : statefulComponent.State;
            if (statefulComponent.ShouldUpdate(current, newComponentState))
            {
                UpdateComponent(current, statefulComponent, newComponentState);
            }
            if (nativeCurrent != null)
            {
                // native elements don't render but rather yield native Element
                return (TElement)nativeCurrent.Element;
            }
            else
            {
                // non-native components will render a tree (of non and native props)
                var component = (ISharpComponent)statefulComponent;
                var compositeCurrentProp = (ISharpCompositeProp)current;
                // generate nested props
                compositeCurrentProp.Generated = statefulComponent.Render();
                // process the recursively
                var compositePreviousProp = currentPrevious as ISharpCompositeProp;
                VisitAll(level+1, newState, nativeRoot, compositePreviousProp?.Generated, compositeCurrentProp.Generated);
                // sooner or later a native element will be returned
                return nativeRoot;
            }
        }

        public TElement VisitAll(int level, NewState newState, TElement nativeRoot, ISharpProp previous, ISharpProp root)
        {
            if (!ReferenceEquals(root, null))
            {
                var result = ProcessPair(level, newState, nativeRoot, previous, root);
                if (root is SharpNativeProp)
                {
                    if (root is IChildrenContainer childContainer)
                    {
                        VisitChildrenContainer(level, newState, result, previous as IChildrenContainer, childContainer);
                    }
                    else if (root is IContainer container)
                    {
                        VisitContainer(level, newState, result, previous as IContainer, container);
                    }
                }
                return result;
            }
            else
            {
                return default(TElement);
            }
        }

        public void VisitChildrenContainer(int level, NewState newState, TElement nativeRoot, IChildrenContainer previous, IChildrenContainer current)
        {
            for (int i = 0; i < current.Children.Count; i++)
            {
                var currentChild = current.Children[i];
                var previousChild = previous?.Children?[i];
                VisitAll(level+1, newState, nativeRoot, previousChild, currentChild);
            }
        }

        public void VisitContainer(int level, NewState newState, TElement nativeRoot, IContainer previous, IContainer current)
        {
            VisitAll(level+1, newState, nativeRoot, previous?.Content, current.Content);
        }

        public void StateChanged(NewState newState)
        {
            Task.Factory.StartNew(() => Invalidate(newState), CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }

        private string GetTypeName<T>(T current)
        {
            return typeof(T).Name;
        }
    }
}
