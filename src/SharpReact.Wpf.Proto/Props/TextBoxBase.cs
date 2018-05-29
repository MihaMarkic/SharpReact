using SharpReact.Core;
using System;
using System.Windows.Controls;

namespace SharpReact.Wpf.Props
{
    public abstract class TextBoxBase: Control
    {
        public bool? IsReadOnly { get; set; }
        public TextChangedEventHandler TextChanged { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            throw new InvalidOperationException();
        }
    }
}
