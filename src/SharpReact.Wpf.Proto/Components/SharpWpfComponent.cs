using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Wpf.Components
{
    public class SharpWpfComponent<TProps, TState, TElement> : SharpNativeComponent<TProps,TState, TElement, System.Windows.UIElement>
        where TProps : SharpNativeProp
        where TElement: System.Windows.UIElement, new ()
    {
        public override void WillMount()
        {
            Element = new TElement();
            base.WillMount();
        }
    }
}