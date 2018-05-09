using SharpReact.Core;
using System.Windows;

namespace SharpReact.Wpf.Props
{
    public class FrameworkElement: UIElement
    {
        public bool? Focusable { get; set; }
        public HorizontalAlignment? HorizontalAlignment { get; set; }
        public VerticalAlignment? VerticalAlignment { get; set; }
        public Thickness? Margin { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.FrameworkElement<FrameworkElement, System.Windows.FrameworkElement>();
        }
    }
}
