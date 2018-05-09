using SharpReact.Core;

namespace SharpReact.Wpf.Props
{
    public class Button: ButtonBase
    {
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.Button<Button, System.Windows.Controls.Button>();
        }
    }
}