namespace SharpReact.Core.MockUI.Test.Components
{
    public abstract class TextBoxBase<TProps, TElement> : Control<TProps, TElement>
        where TProps : Props.TextBoxBase
        where TElement : Elements.TextBoxBase, new()
    {
        public override void AssignProperties(ISharpRenderer<Core.MockUI.Test.Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            UpdateTextBoxBaseWithInstanceProperties(Element, previous, nextProps);
        }
        protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
        {
            base.UpdateElement(renderer, element, props);
            UpdateTextBoxBaseWithInstanceProperties(element, null, props);
        }
        static void UpdateTextBoxBaseWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
        {
            if (nextProps.IsReadOnly.HasValue)
            {
                element.IsReadOnly = nextProps.IsReadOnly.Value;
            }
        }
    }
}
