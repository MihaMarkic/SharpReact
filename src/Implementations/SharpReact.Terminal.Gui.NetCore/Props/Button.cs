using NStack;
using SharpReact.Core;
using System;

namespace SharpReact.Terminal.Gui.Props
{
    public class Button: View
    {
        public Action Clicked { get; set; }
        public ReactParam<bool>? IsDefault { get; set; }
        public ReactParam<ustring>? Text { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.Button();
        }
    }
}
