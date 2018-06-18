
namespace SharpReact.Core.MockUI.Test.Components
{
    public class StackPanel<TProps, TElement> : Panel<TProps, TElement>
        where TProps : Props.StackPanel
        where TElement : Elements.StackPanel, new()
    {
        public override void AssignProperties(ISharpRenderer<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            UpdateStackPanelWithInstanceProperties(Element, previous, nextProps);
        }
        protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
        {
            base.UpdateElement(renderer, element, props);
            UpdateStackPanelWithInstanceProperties(element, null, props);
        }
        static void UpdateStackPanelWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
        {
            if (nextProps.Orientation.HasValue)
            {
                element.Orientation = nextProps.Orientation.Value;
            }
        }
    }
}
