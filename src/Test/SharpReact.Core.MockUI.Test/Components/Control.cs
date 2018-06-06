namespace SharpReact.Core.MockUI.Test.Components
{
    public class Control<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.Control
        where TElement : Core.MockUI.Test.Elements.Control, new()
    {
        public override void AssignProperties(ISharpCreator<Core.MockUI.Test.Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            //if (nextProps.FontSize.HasValue)
            //{
            //    Element.FontSize = nextProps.FontSize.Value;
            //}
        }
    }
}
