namespace SharpReact.Core.MockUI.Test.Components
{
    public abstract class ButtonBase<TProps, TElement> : ContentControl<TProps, TElement>
        where TProps : Props.ButtonBase
        where TElement : Elements.ButtonBase, new()
    {
        public override void AssignProperties(ISharpRenderer<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            UpdateButtonBaseWithInstanceProperties(Element, previous, nextProps);
        }
        protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps prop)
        {
            base.UpdateElement(renderer, element, prop);
            UpdateButtonBaseWithInstanceProperties(Element, null, prop);
        }
        static void UpdateButtonBaseWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
        {
            if (!ReferenceEquals(previous?.Click, null) && ReferenceEquals(nextProps.Click, null))
            {
                element.Click -= previous.Click;
            }
            if (ReferenceEquals(previous?.Click, null) && !ReferenceEquals(nextProps.Click, null))
            {
                element.Click += nextProps.Click;
            }
        }
    }
}
