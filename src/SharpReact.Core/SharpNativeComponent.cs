using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public abstract class SharpNativeComponent<TProps, TState, TElement, TRootElement> : SharpStatefulComponent<TProps, TState>, ISharpNativeComponent
        where TProps : SharpNativeProp
    {
        public new TElement Element { get => (TElement)base.Element; protected set => base.Element = value; }
        public override ISharpProp Render()
        {
            return null;
        }

        object ISharpStatefulComponent.Element => Element;
        void ISharpNativeComponent.AssignProperties(ISharpRenderer renderer, int level, NewState newState, ISharpProp previous, ISharpProp nextProps)
        {
            AssignProperties((ISharpCreator<TRootElement>)renderer, level, newState, (TProps)previous, (TProps)nextProps);
        }
        public virtual void AssignProperties(ISharpCreator<TRootElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {}
    }
}
