
namespace SharpReact.Core.MockUI.Test.Components
{
    public abstract class Panel<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.Panel
        where TElement : Elements.Panel, new()
    {
        public override void AssignProperties(ISharpRenderer<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            {
                var elements = renderer.VisitAllCollection(level, newState, previous?.Children, nextProps.Children, nameof(Element.Children), nameof(Elements.Panel));
                ElementSynchronizer.SyncElements(Element.Children, elements);
            }
        }
        protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
        {
            base.UpdateElement(renderer, element, props);
            for (int i = 0; i < props.Children.Count; i++)
            {
                var child = props.Children[i];
                renderer.UpdateExistingElement(element.Children[i], child);
            }
        }
    }
}
