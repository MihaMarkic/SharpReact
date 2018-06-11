using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Terminal.Gui.Components
{
    public abstract class SharpTerminalGuiComponent<TProps, TElement> : SharpNativeComponent<TProps, object, TElement, global::Terminal.Gui.View>
            where TProps : SharpNativeProp
            where TElement : global::Terminal.Gui.View
    {
    }
}
