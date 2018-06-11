namespace SharpReact.Core.MockUI.Test.Components
{
    public abstract class ButtonBase<TProps, TElement> : ContentControl<TProps, TElement>
        where TProps : Props.ButtonBase
        where TElement : Elements.ButtonBase, new()
    {
        public override void AssignProperties(ISharpCreator<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (!ReferenceEquals(previous?.Click, null) && ReferenceEquals(nextProps.Click, null))
            {
                Element.Click -= Props.Click;
            }
            if (ReferenceEquals(previous?.Click, null) && !ReferenceEquals(nextProps.Click, null))
            {
                Element.Click += nextProps.Click;
            }
        }
    }
}
