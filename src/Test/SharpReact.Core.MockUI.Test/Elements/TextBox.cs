using System;

namespace SharpReact.Core.MockUI.Test.Elements
{
    public class TextBox : TextBoxBase
    {
        public string Text { get; set; }
        public event EventHandler TextChanged;
    }
}
