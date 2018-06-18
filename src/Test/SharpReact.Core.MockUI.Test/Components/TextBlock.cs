
namespace SharpReact.Core.MockUI.Test.Components
{
    public class TextBlock<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.TextBlock
        where TElement : Core.MockUI.Test.Elements.TextBlock, new()
    {
        public override void AssignProperties(ISharpRenderer<Core.MockUI.Test.Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            UpdateTextBlockWithInstanceProperties(Element, previous, nextProps);
        }
        protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
        {
            base.UpdateElement(renderer, element, props);
            UpdateTextBlockWithInstanceProperties(element, null, props);
        }
        static void UpdateTextBlockWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
        {
            if (nextProps.Text.HasValue)
            {
                element.Text = nextProps.Text.Value;
            }
        }
    }
}
