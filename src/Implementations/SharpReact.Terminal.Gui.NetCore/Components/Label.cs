using SharpReact.Core;

namespace SharpReact.Terminal.Gui.Components
{
    public class Label : View<Props.Label, global::Terminal.Gui.Label>
    {
        public override void WillMount()
        {
            Element = new global::Terminal.Gui.Label("");
            base.WillMount();
        }
        public override void AssignProperties(ISharpCreator<global::Terminal.Gui.View> renderer, int level, NewState newState, Props.Label previous, Props.Label nextProps)
        {
            if (nextProps.Text.HasValue)
            {
                Element.Text = nextProps.Text.Value;
            }
            if (nextProps.TextAlignment.HasValue)
            {
                Element.TextAlignment = nextProps.TextAlignment.Value;
            }
            if (nextProps.TextColor.HasValue)
            {
                Element.TextColor = nextProps.TextColor.Value;
            }
            base.AssignProperties(renderer, level, newState, previous, nextProps);
        }
    }
}
