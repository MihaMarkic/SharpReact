namespace SharpReact.Core.MockUI.Test.Components
{
    public class Control<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.Control
        where TElement : Elements.Control, new()
    {
        public override void AssignProperties(ISharpRenderer<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            UpdateControlWithInstanceProperties(Element, previous, nextProps);
        }
        protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
        {
            base.UpdateElement(renderer, element, props);
            UpdateControlWithInstanceProperties(element, null, props);
        }
        static void UpdateControlWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
        {
            if (nextProps.FontSize.HasValue)
            {
                element.FontSize = nextProps.FontSize.Value;
            }
        }
    }
}
