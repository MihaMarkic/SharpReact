using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public class SharpNativeComponent<TProps, TState, TElement> : SharpStatefulComponent<TProps, TState>, ISharpNativeComponent
        where TProps : SharpNativeProp
    {
        public new TElement Element { get; protected set; }
        public override ISharpProp Render()
        {
            return null;
        }

        object ISharpStatefulComponent.Element => Element;
    }
}
