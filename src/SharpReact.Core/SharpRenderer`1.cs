using SharpReact.Core.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SharpReact.Core
{
    public abstract class SharpRenderer<TRootElement, TElement>: ISharpRenderer<TElement>
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
            var nativeCurrent = statefulComponent as ISharpNativeComponent;
            statefulComponent.WillMount();
            if (nativeCurrent != null)
            {
                CreateElement(nativeCurrent);
            }
            statefulComponent.DidMount();
            return (statefulComponent, nativeCurrent);
        }
        protected abstract void CreateElement(ISharpNativeComponent nativeComponent);
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
        public void UpdateExistingElement(object element, ISharpProp prop)
        {
            UpdateExistingElement((TElement)element, prop);
        }
        /// <summary>
        /// Updates existing element properties.
        /// </summary>
        /// <remarks>Used with template based rendering.</remarks>
        /// <param name="element"></param>
        /// <param name="prop"></param>
        public void UpdateExistingElement(TElement element, ISharpProp prop)
        {
            prop.Init();
            prop.Component.WillMount();
            // UpdateElement expects all sub-elements to be created and be in proper position in list.
            prop.Component.UpdateElement(this, element, prop);
            prop.Component.DidMount();
        }
        /// <summary>
        /// Removes element from components.
        /// </summary>
        /// <remarks>Used with template based rendering.</remarks>
        /// <param name="prop"></param>
        public void RemoveElement(TElement element, ISharpProp prop)
        {
            var query = from p in prop.AllChildren.Union(new ISharpProp[] { prop })
                        where !ReferenceEquals(p, null) && ReferenceEquals(p.Component?.Element, element)
                        let n = p.Component as ISharpNativeComponent
                        where n != null
                        select n;
            foreach (var p in query)
            {
                p.RemoveElement();
            }
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
        public bool ComparePropertyLists(ISharpProp[] left, ISharpProp[] right)
        {
            if (left is null && right is null)
            {
                return true;
            }
            if (left?.Length != right?.Length)
            {
                return false;
            }
            for (int i = 0; i < left.Length; i++)
            {
                if (!CompareProperties(left[i], right[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool CompareProperties<T>(T left, T right)
            where T: ISharpProp
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }
            if (ReferenceEquals(right, null))
            {
                return false;
            }
            var rightProps = right.AllProperties.GetEnumerator();
            foreach (var leftProp in left.AllProperties)
            {
                rightProps.MoveNext();
                if (ReferenceEquals(leftProp, null))
                {
                    if (!ReferenceEquals(rightProps.Current, null))
                    {
                        return false;
                    }
                }
                else if (!leftProp.Equals(rightProps.Current))
                {
                    return false;
                }
            }
            if (left.AllChildren.Count() != right.AllChildren.Count())
            {
                return false;
            }
            var rightChildren = right.AllChildren.GetEnumerator();
            foreach (var leftChild in left.AllChildren)
            {
                if (!rightChildren.MoveNext())
                {
                    return false;
                }
                if (!CompareProperties(leftChild, rightChildren.Current))
                {
                    return false;
                }
            }
            if (rightChildren.MoveNext())
            {
                return false;
            }

            return true;
        }
    }
}
