namespace SharpReact.Core.MockUI.Test.Components
{
    public class TextBox<TProps, TElement> : TextBoxBase<TProps, TElement>
        where TProps : Props.TextBox
        where TElement : Elements.TextBox, new()
    {
        public override void AssignProperties(ISharpRenderer<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            UpdateTextBoxWithInstanceProperties(Element, previous, nextProps);
        }
        protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
        {
            base.UpdateElement(renderer, element, props);
            UpdateTextBoxWithInstanceProperties(element, null, props);
        }
        static void UpdateTextBoxWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
        {
            if (nextProps.Text.HasValue)
            {
                element.Text = nextProps.Text.Value;
            }
            if (!ReferenceEquals(previous?.TextChanged, null) && ReferenceEquals(nextProps.TextChanged, null))
            {
                element.TextChanged -= previous.TextChanged;
            }
            if (ReferenceEquals(previous?.TextChanged, null) && !ReferenceEquals(nextProps.TextChanged, null))
            {
                element.TextChanged += nextProps.TextChanged;
            }
        }
    }
}
