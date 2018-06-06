using System;

namespace SharpReact.Core.MockUI.Test.Props
{
    public abstract class TextBoxBase: Control
    {
        public ReactParam<bool>? IsReadOnly { get; set; }
        //public TextChangedEventHandler TextChanged { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            throw new InvalidOperationException();
        }
    }
}
