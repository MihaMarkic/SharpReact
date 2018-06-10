using SharpReact.Core.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SharpReact.Core
{
    public abstract class SharpRenderer<TRootElement, TElement>: ISharpRenderer, ISharpCreator<TElement>
        where TRootElement: TElement
    {
        SharpProp currentProps;
        TElement currentElement;
        readonly Func<SharpProp> createTree;
        readonly TaskFactory taskFactory;
        readonly Action<TRootElement, TElement> attachChildToRoot;
        readonly Action<TRootElement, TElement> detachChildFromRoot;
        bool isInvalidated;
        public TRootElement Parent { get;  }

        public SharpRenderer(Func<SharpProp> createTree, TRootElement parent, 
            Action<TRootElement, TElement> attachChildToRoot, Action<TRootElement, TElement> detachChildFromRoot,
            TaskScheduler uiScheduler)
        {
            taskFactory = new TaskFactory(uiScheduler);
            this.createTree = createTree;
            Parent = parent;
            this.attachChildToRoot = attachChildToRoot;
            this.detachChildFromRoot = detachChildFromRoot;
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
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Render(NewState newState)
        {
            var root = createTree();
            var next = UpdateTree(newState, root);
            if (!ReferenceEquals(currentElement, null) && !ReferenceEquals(next, currentElement))
            {
                UnmountComponents(currentProps);
                detachChildFromRoot(Parent, currentElement);
            }
            attachChildToRoot(Parent, next);
            currentProps = root;
            currentElement = next;
        }
        static void UnmountComponents(ISharpProp prop)
        {
            ((ISharpInternal)prop)?.UnmountComponent();
        }
        public void Redraw()
        {
            Render(NewState.Empty);
        }
        public TElement UpdateTree(NewState newState, SharpProp next)
        {
            return VisitAll(0, newState, currentProps, next);
        }
        public (ISharpStatefulComponent Stateful, ISharpNativeComponent Native) CreateNewComponent(ISharpProp next)
        {
            next.Init();
            var statefulComponent = next.Component;
            statefulComponent.Renderer = this;
            statefulComponent.WillMount();
            var nativeCurrent = statefulComponent as ISharpNativeComponent;
            statefulComponent.DidMount();
            return (statefulComponent, nativeCurrent);
        }
        public void UpdateComponent(int level, NewState newState, ISharpProp previous, ISharpProp next, ISharpStatefulComponent statefulComponent, object newComponentState)
        {
            statefulComponent.WillReceiveProps(next);
            // assign properties to one or the another, perhaps an if should do better
            if (statefulComponent is ISharpNativeComponent nativeComponent)
            {
                nativeComponent.AssignProperties(this, level, newState, previous, next);
            }
            else if (statefulComponent is ISharpComponent component)
            {
                component.AssignProperties(next);
            }
            else
            {
                throw new NotImplementedException("Unknown component type or null");
            }
            statefulComponent.DidUpdate(next, newComponentState);
        }

        public TElement ProcessPair(int level, NewState newState, ISharpProp previous, ISharpProp next)
        {
            if (ReferenceEquals(next, null))
            {
                return default;
            }
            ISharpStatefulComponent statefulComponent;
            ISharpNativeComponent nativeCurrent;
            // this can be reset to null if old branch gets deleted
            ISharpProp currentPrevious = previous;
            bool typeMatch = true;
            if (ReferenceEquals(currentPrevious, null))
            {
                (statefulComponent, nativeCurrent) = CreateNewComponent(next);
            }
            else if (currentPrevious.GetType() != next.GetType())
            {
                typeMatch = false;
                UnmountComponents(currentPrevious);
                //Detach(nativeRoot, (TElement)currentPrevious.Component.Element);
                (statefulComponent, nativeCurrent) = CreateNewComponent(next);
            }
            else
            {
                statefulComponent = currentPrevious.Component;
                next.Transfer(statefulComponent);
                nativeCurrent = statefulComponent as ISharpNativeComponent;
            }
            // new state is assigned if matching
            object newComponentState = newState.Props == currentPrevious ? newState.State : statefulComponent.State;
            if (statefulComponent.ShouldUpdate(next, newComponentState))
            {
                UpdateComponent(level, newState, typeMatch ? previous: null, next, statefulComponent, newComponentState);
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
                var compositeNextProp = (ISharpCompositeProp)next;
                // generate nested props
                compositeNextProp.Generated = statefulComponent.Render();
                // process the recursively
                var compositePreviousProp = currentPrevious as ISharpCompositeProp;
                var element = VisitAll(level+1, newState, compositePreviousProp?.Generated, compositeNextProp.Generated);
                // sooner or later a native element will be returned
                return element;
            }
        }

        public TElement VisitAll(int level, NewState newState, ISharpProp previous, ISharpProp root)
        {
            if (!ReferenceEquals(root, null))
            {
                var result = ProcessPair(level, newState, previous, root);
                return result;
            }
            else
            {
                return default;
            }
        }
        /// <summary>
        /// Simple implementation of diff against two lists. There is room for improvement.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="newState"></param>
        /// <param name="previous">Previous list of properties to compare against.</param>
        /// <param name="next">Properties being applied.</param>
        /// <param name="sourceProperty"></param>
        /// <param name="sourceType"></param>
        /// <param name="elements">Native list of elements.</param>
        public TElement[] VisitAllCollection(int level, NewState newState, IList<ISharpProp> previous, IList<ISharpProp> next,
            string sourceProperty, string sourceType)
        {
            CheckPropertyListKeys(next, sourceProperty, sourceType);
            int prevCount = previous?.Count ?? 0;
            int nextCount = next?.Count ?? 0;
            var elements = new TElement[nextCount];
            for (int i = 0; i < Math.Min(prevCount, nextCount); i++)
            {
                var n = next[i];
                var p = previous[i];
                var element = ProcessPair(level + 1, newState, p, n);
                elements[i] = element;
            }
            // adds excessive new properties
            if (nextCount > prevCount)
            {
                for (int i = prevCount; i < nextCount; i++)
                {
                    var n = next[i];
                    var element = ProcessPair(level + 1, newState, null, n);
                    elements[i] = element;
                }
            }
            return elements;
        }
        /// <summary>
        /// Verifies that property list keys are unique.
        /// </summary>
        /// <param name="props"></param>
        /// <param name="sourceProperty"></param>
        /// <param name="sourceType"></param>
        /// <threadsafety>Thread safe.</threadsafety>
        public static void CheckPropertyListKeys(IList<ISharpProp> props, string sourceProperty, string sourceType)
        {
            // TODO keys uniqueness check disabled for the time being
            // Perhaps not required at all
            //if (props?.Count > 0)
            //{
            //    var set = new HashSet<object>();
            //    foreach (var p in props)
            //    {
            //        if (!set.Add(p.Key))
            //        {
            //            throw new DuplicateKeyException(p, sourceProperty, sourceType);
            //        }
            //    }
            //}
        }
        public void StateChanged(NewState newState)
        {
            taskFactory.StartNew(() => Invalidate(newState), CancellationToken.None);
        }
    }
}
