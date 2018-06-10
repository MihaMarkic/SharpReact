
namespace SharpReact.Core.MockUI.Test.Components
{
    public abstract class Panel<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.Panel
        where TElement : Elements.Panel, new()
    {
        public override void AssignProperties(ISharpCreator<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            {
                var elements = renderer.VisitAllCollection(level, newState, previous?.Children, nextProps.Children, nameof(Element.Children), nameof(Elements.Panel));
                ElementSynchronizer.SyncElements(Element.Children, elements);
            }
        }
    }
}
