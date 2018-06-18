using SharpReact.Core;

namespace SharpReact.Terminal.Gui.Components
{
    public class Button: View<Props.Button, global::Terminal.Gui.Button>
    {
        public override void CreateElement()
        {
            Element = new global::Terminal.Gui.Button("");
        }
        public override void AssignProperties(ISharpRenderer<global::Terminal.Gui.View> renderer, int level, NewState newState, Props.Button previous, Props.Button nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (nextProps.IsDefault.HasValue)
            {
                Element.IsDefault = nextProps.IsDefault.Value;
            }
            if (nextProps.Text.HasValue)
            {
                Element.Text = nextProps.Text.Value;
            }
            Element.Clicked = nextProps.Clicked;
        }
    }
}
