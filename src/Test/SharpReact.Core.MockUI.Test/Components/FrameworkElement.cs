namespace SharpReact.Core.MockUI.Test.Components
{
    public class FrameworkElement<TProps, TElement> : UIElement<TProps, TElement>
        where TProps : Props.FrameworkElement
        where TElement : Elements.FrameworkElement, new()
    {
        public override void AssignProperties(ISharpRenderer<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            UpdateFrameworkElementWithInstanceProperties(Element, previous, nextProps);
        }
        protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
        {
            base.UpdateElement(renderer, element, props);
            UpdateFrameworkElementWithInstanceProperties(element, null, props);
        }
        static void UpdateFrameworkElementWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
        {
            if (nextProps.Focusable.HasValue)
            {
                element.Focusable = nextProps.Focusable.Value;
            }
        }
    }
}
