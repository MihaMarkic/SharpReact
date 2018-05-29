using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Wpf.Components
{
    public abstract class SharpWpfComponent<TProps, TState, TElement> : SharpNativeComponent<TProps,TState, TElement>
        where TProps : SharpNativeProp
        where TElement: System.Windows.UIElement
    {
        public override void WillMount()
        {
            CreateElement();
            base.WillMount();
        }
        protected abstract void CreateElement();
    }
}