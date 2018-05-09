using SharpReact.Core;
using System.Windows.Controls;

namespace SharpReact.Wpf.Props
{
    public class StackPanel: Panel
    {
        public Orientation? Orientation { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.StackPanel<StackPanel, System.Windows.Controls.StackPanel>();
        }
    }
}
