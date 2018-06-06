using SharpReact.Core.Properties;
using System;

namespace SharpReact.Core.MockUI.Test.Props
{
    public class UIElement: SharpNativeProp
    {
        public ReactParam<bool>? IsEnabled { get; set; }
        //public Visibility? Visibility { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            throw new InvalidOperationException();
        }
    }
}
