using SharpReact.Core.Properties;
using System;

namespace SharpReact.Core
{
    public abstract class SharpStatefulComponent<TProps, TState, TElement> : ISharpStatefulComponent<TElement>
        where TProps : SharpProp
    {
        public ISharpRenderer Renderer { get; set; }
        public TElement Element { get; protected set; }
        object ISharpStatefulComponent.Element => Element;
        public TState State { get; private set; }
        public TProps Props { get; private set; }
        public SharpStatefulComponent()
        { }
        public virtual void WillMount()
        { }
        public virtual void DidMount()
        { }
        public virtual void WillReceiveProps(TProps nextProps)
        {

        }
        public virtual bool ShouldUpdate(TProps nextProps, TState nextState)
        {
            return true;
        }
        public virtual void WillUpdate()
        { }
        public virtual void DidUpdate(TProps nextProps, TState nextState)
        {
            Props = nextProps;
            State = nextState;
        }
        public virtual void WillUnmount()
        { }
        /// <summary>
        /// Returns a tree when composite, otherwise returns null.
        /// </summary>
        /// <returns></returns>
        public abstract ISharpProp Render();

        protected void SetState(TState newState)
        {
            Renderer.StateChanged(new NewState(Props, newState));
        }

        protected void Redraw()
        {
            Renderer.Redraw();
        }

        void ISharpStatefulComponent.WillReceiveProps(object nextProps)
        {
            WillReceiveProps((TProps)nextProps);
        }

        bool ISharpStatefulComponent.ShouldUpdate(object nextProps, object nextState)
        {
            return ShouldUpdate((TProps)nextProps, ReferenceEquals(nextState, null) ? default : (TState)nextState);
        }

        void ISharpStatefulComponent.DidUpdate(object nextProps, object nextState)
        {
            DidUpdate((TProps)nextProps, ReferenceEquals(nextState, null) ? default : (TState)nextState);
        }
        object ISharpStatefulComponent.State => State;
        object ISharpStatefulComponent.Props => Props;
        /// <summary>
        /// Run time update of the existing element
        /// </summary>
        /// <param name="element"></param>
        void ISharpStatefulComponent<TElement>.UpdateElement(ISharpRenderer<TElement> renderer, TElement element, ISharpProp props)
        {
            UpdateElement(renderer, element, (TProps)props);
        }
        void ISharpStatefulComponent.UpdateElement(ISharpRenderer renderer, object element, ISharpProp props)
        {
            UpdateElement(renderer, (TElement)element, (TProps)props);
        }
        protected virtual void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
        { }
    }
}
