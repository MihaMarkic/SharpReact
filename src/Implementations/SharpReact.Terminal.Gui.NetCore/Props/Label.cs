using NStack;
using SharpReact.Core;
using Terminal.Gui;

namespace SharpReact.Terminal.Gui.Props
{
    public class Label: View
    {
        public ReactParam<ustring>? Text { get; set; }
        public ReactParam<TextAlignment>? TextAlignment { get; set; }
        public ReactParam<Attribute>? TextColor { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.Label();
        }
    }
}
