using SharpReact.Core;

namespace SharpReact.Terminal.Gui.Components
{
    public class Window : TopLevel<Props.Window, global::Terminal.Gui.Window>
    {
        public override void CreateElement()
        {
            Element = new global::Terminal.Gui.Window(null);
        }
        public override void AssignProperties(ISharpCreator<global::Terminal.Gui.View> renderer, int level, NewState newState, Props.Window previous, Props.Window nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (nextProps.Title.HasValue)
            {
                Element.Title = nextProps.Title.Value;
            }
        }
    }
}
