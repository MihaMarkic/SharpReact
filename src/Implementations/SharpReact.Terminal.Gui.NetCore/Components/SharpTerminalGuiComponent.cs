using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Terminal.Gui.Components
{
    internal interface IElementCreator
    {
        void CreateElement();
    }
    public abstract class SharpTerminalGuiComponent<TProps, TElement> : SharpNativeComponent<TProps, object, TElement, global::Terminal.Gui.View>, IElementCreator
            where TProps : SharpNativeProp
            where TElement : global::Terminal.Gui.View
    {
        public abstract void CreateElement();
    }
}
