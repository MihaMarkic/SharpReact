using System;

namespace SharpReact.Core.MockUI.Test.Props
{
    public class TextBox: TextBoxBase
    {
        public EventHandler TextChanged { get; set; }
        public ReactParam<string> Text { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.TextBox<TextBox, Elements.TextBox>();
        }
    }
}
