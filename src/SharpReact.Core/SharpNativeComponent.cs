using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Core
{
    public abstract class SharpNativeComponent<TProps, TState, TElement, TRootElement> : SharpStatefulComponent<TProps, TState, TElement>, ISharpNativeComponent
        where TProps : SharpNativeProp
    {
        public void RemoveElement()
        {
            Element = default;
        }
        public override ISharpProp Render()
        {
            return null;
        }
        object ISharpStatefulComponent.Element => Element;
        void ISharpNativeComponent.AssignProperties(ISharpRenderer renderer, int level, NewState newState, ISharpProp previous, ISharpProp nextProps)
        {
            AssignProperties((ISharpRenderer<TRootElement>)renderer, level, newState, (TProps)previous, (TProps)nextProps);
        }
        public virtual void AssignProperties(ISharpRenderer<TRootElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {}
        public virtual void AssignContainerProperties(ISharpRenderer<TRootElement> renderer, int level, NewState newState, List<ISharpProp> previous, List<ISharpProp> nextProps, string propertyName, string containerName)
        { }
    }
}
