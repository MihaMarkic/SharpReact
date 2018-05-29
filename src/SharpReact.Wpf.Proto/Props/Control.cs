using SharpReact.Core;

namespace SharpReact.Wpf.Props
{
    public class Control: FrameworkElement
    {
        public double? FontSize { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.Control<Control, System.Windows.Controls.Control>();
        }
    }
}
