using System;

namespace SharpReact.Core.MockUI.Test.Props
{
    public class FrameworkElement: UIElement
    {
        public bool? Focusable { get; set; }
        //public HorizontalAlignment? HorizontalAlignment { get; set; }
        //public VerticalAlignment? VerticalAlignment { get; set; }
        //public Thickness? Margin { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            throw new InvalidOperationException();
        }
    }
}
