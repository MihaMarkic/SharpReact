namespace SharpReact.Core.MockUI.Test.Props
{
    public class TextBox: TextBoxBase
    {
        public  string Text { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.TextBox<TextBox, Elements.TextBox>();
        }
    }
}
