using SharpReact.Core;

namespace SharpReact.Wpf.Props
{
    public class TextBox: TextBoxBase
    {
        public  string Text { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.TextBox<TextBox, System.Windows.Controls.TextBox>();
        }
    }
}
