using SharpReact.Core;

namespace SharpReact.Terminal.Gui.Components
{
    public class TextField : View<Props.TextField, global::Terminal.Gui.TextField>
    {
        public override void CreateElement()
        {
            Element = new global::Terminal.Gui.TextField("");
        }
        public override void AssignProperties(ISharpCreator<global::Terminal.Gui.View> renderer, int level, NewState newState, Props.TextField previous, Props.TextField nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (nextProps.Text.HasValue)
            {
                Element.Text = nextProps.Text.Value;
            }
            if (nextProps.Secret.HasValue)
            {
                Element.Secret = nextProps.Secret.Value;
            }
            if (!ReferenceEquals(previous?.Changed, null) && ReferenceEquals(nextProps.Changed, null))
            {
                Element.Changed -= Props.Changed;
            }
            if (ReferenceEquals(previous?.Changed, null) && !ReferenceEquals(nextProps.Changed, null))
            {
                Element.Changed += nextProps.Changed;
            }
        }
    }
}
