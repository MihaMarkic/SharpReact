using SharpReact.Core.Exceptions;
using SharpReact.Core.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SharpReact.Core
{
    public interface ISharpCreator<TElement>
    {
        TElement ProcessPair(int level, NewState newState, ISharpProp previous, ISharpProp current);
        void VisitAllCollection(int level, NewState newState, IList<ISharpProp> previous, IList<ISharpProp> next,
            IList elements, string sourceProperty, string sourceType);
    }
    public abstract class SharpRenderer<TRootElement, TElement>: ISharpRenderer, ISharpCreator<TElement>
        where TRootElement: TElement
    {
        SharpProp previous;
        TElement previousElement;
        public TRootElement Parent { get;  }
        readonly Func<SharpProp> createTree;
        bool isInvalidated;
        TaskScheduler uiScheduler;
        readonly Action<TRootElement, TElement> attachChildToRoot;
        readonly Action<TRootElement, TElement> detachChildFromRoot;

        public SharpRenderer(Func<SharpProp> createTree, TRootElement parent, 
            Action<TRootElement, TElement> attachChildToRoot, Action<TRootElement, TElement> detachChildFromRoot,
            TaskScheduler uiScheduler)
        {
            this.uiScheduler = uiScheduler;
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
            var current = UpdateTree(newState, root);
            if (!ReferenceEquals(previousElement, null) && !ReferenceEquals(current, previousElement))
            {
                UnmountComponents(previous);
                detachChildFromRoot(Parent, previousElement);
            }
            attachChildToRoot(Parent, current);
            previous = root;
            previousElement = current;
        }
        static void UnmountComponents(ISharpProp prop)
        {
            ((ISharpInternal)prop)?.UnmountComponent();
        }
        public void Redraw()
        {
            Render(NewState.Empty);
        }
        public TElement UpdateTree(NewState newState, SharpProp current)
        {
            return VisitAll(0, newState, previous, current);
        }
        public (ISharpStatefulComponent Stateful, ISharpNativeComponent Native) CreateNewComponent(ISharpProp current)
        {
            current.Init();
            var statefulComponent = current.Component;
            statefulComponent.Renderer = this;
            statefulComponent.WillMount();
            var nativeCurrent = statefulComponent as ISharpNativeComponent;
            statefulComponent.DidMount();
            return (statefulComponent, nativeCurrent);
        }
        public void UpdateComponent(int level, NewState newState, ISharpProp previous, ISharpProp current, ISharpStatefulComponent statefulComponent, object newComponentState)
        {
            statefulComponent.WillReceiveProps(current);
            // assign properties to one or the another, perhaps an if should do better
            if (statefulComponent is ISharpNativeComponent nativeComponent)
            {
                nativeComponent.AssignProperties(this, level, newState, previous, current);
            }
            else if (statefulComponent is ISharpComponent component)
            {
                component.AssignProperties(current);
            }
            else
            {
                throw new NotImplementedException("Unknown component type or null");
            }
            statefulComponent.DidUpdate(current, newComponentState);
        }

        public TElement ProcessPair(int level, NewState newState, ISharpProp previous, ISharpProp current)
        {
            if (ReferenceEquals(current, null))
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
                (statefulComponent, nativeCurrent) = CreateNewComponent(current);
            }
            else if (currentPrevious.GetType() != current.GetType())
            {
                typeMatch = false;
                UnmountComponents(currentPrevious);
                //Detach(nativeRoot, (TElement)currentPrevious.Component.Element);
                currentPrevious = null;
                (statefulComponent, nativeCurrent) = CreateNewComponent(current);
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
                UpdateComponent(level, newState, typeMatch ? previous: null, current, statefulComponent, newComponentState);
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
                VisitAll(level+1, newState, compositePreviousProp?.Generated, compositeCurrentProp.Generated);
                // sooner or later a native element will be returned
                return default;
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
        /// <param name="nativeRoot"></param>
        /// <param name="previous">Previous list of properties to compare against.</param>
        /// <param name="next">Properties being applied.</param>
        /// <param name="sourceProperty"></param>
        /// <param name="sourceType"></param>
        public void VisitAllCollection(int level, NewState newState, IList<ISharpProp> previous, IList<ISharpProp> next,
            IList elements, string sourceProperty, string sourceType)
        {
            CheckPropertyListKeys(next, sourceProperty, sourceType);
            int prevCount = previous?.Count ?? 0;
            int nextCount = next?.Count ?? 0;
            for (int i = 0; i < Math.Min(prevCount, nextCount); i++)
            {
                var n = next[i];
                var p = previous[i];
                var element = ProcessPair(level + 1, newState, p, n);
                if (!ReferenceEquals(elements[i], element))
                {
                    elements[i] = element;
                }
            }
            // adds excessive new properties
            if (nextCount > prevCount)
            {
                for (int i = prevCount; i < nextCount; i++)
                {
                    var n = next[i];
                    var element = ProcessPair(level + 1, newState, null, n);
                    elements.Add(element);
                }
            }
            // removes excessive old elements
            else if (nextCount < prevCount)
            {
                for (int i=0; i < (prevCount - nextCount); i++)
                {
                    elements.RemoveAt(elements.Count - 1);
                }
            }
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
            if (props?.Count > 0)
            {
                var set = new HashSet<object>();
                foreach (var p in props)
                {
                    if (!set.Add(p.Key))
                    {
                        throw new DuplicateKeyException(p, sourceProperty, sourceType);
                    }
                }
            }
        }
        public void StateChanged(NewState newState)
        {
            Task.Factory.StartNew(() => Invalidate(newState), CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }
    }
}
