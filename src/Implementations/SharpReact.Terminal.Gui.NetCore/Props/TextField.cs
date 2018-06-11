using NStack;
using SharpReact.Core;
using System;

namespace SharpReact.Terminal.Gui.Props
{
    public class TextField: View
    {
        public EventHandler Changed { get; set; }
        public ReactParam<ustring>? Text { get; set; }
        public ReactParam<bool>? Secret { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.TextField();
        }
    }
}
