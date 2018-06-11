using NStack;
using SharpReact.Core;

namespace SharpReact.Terminal.Gui.Props
{
    public class Window: TopLevel
    {
        public ReactParam<ustring>? Title { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.Window();
        }
    }
}
