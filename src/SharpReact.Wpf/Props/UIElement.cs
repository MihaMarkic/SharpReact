using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Windows;

namespace SharpReact.Wpf.Props
{
    public class UIElement: SharpNativeProp
    {
        public bool? IsEnabled { get; set; }
        public Visibility? Visibility { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.UIElement<UIElement, System.Windows.UIElement>();
        }
    }
}
