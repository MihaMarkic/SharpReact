
namespace SharpReact.Core.MockUI.Test.Props
{
    public class TextBlock: FrameworkElement
    {
        public string Text { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.TextBlock<TextBlock, Core.MockUI.Test.Elements.TextBlock>();
        }
    }
}
