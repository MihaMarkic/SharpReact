using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Wpf.Components
{
    internal interface IElementCreator
    {
        void CreateElement();
    }
    public abstract class SharpWpfComponent<TProps, TState, TElement> : 
        SharpNativeComponent<TProps,TState, TElement, System.Windows.UIElement>, IElementCreator
        where TProps : SharpNativeProp
        where TElement: System.Windows.UIElement, new()
    {
        public void CreateElement()
        {
            Element = new TElement();
        }
    }
}