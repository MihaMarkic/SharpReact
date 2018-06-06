
namespace SharpReact.Core.MockUI.Test.Components
{
    public class StackPanel<TProps, TElement> : Panel<TProps, TElement>
        where TProps : Props.StackPanel
        where TElement : Core.MockUI.Test.Elements.StackPanel, new()
    {
        public override void AssignProperties(ISharpCreator<Core.MockUI.Test.Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            //if (nextProps.Focusable.HasValue)
            //{
            //    Element.Focusable = nextProps.Focusable.Value;
            //}
            //if (nextProps.Orientation.HasValue)
            //{
            //    Element.Orientation = nextProps.Orientation.Value;
            //}
        }
    }
}
