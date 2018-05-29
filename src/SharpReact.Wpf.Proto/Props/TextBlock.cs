using SharpReact.Core;

namespace SharpReact.Wpf.Props
{
    public class TextBlock: FrameworkElement
    {
        public string Text { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.TextBlock<TextBlock, System.Windows.Controls.TextBlock>();
        }
    }
}
