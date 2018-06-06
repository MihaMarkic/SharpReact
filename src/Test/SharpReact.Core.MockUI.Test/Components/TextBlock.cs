
namespace SharpReact.Core.MockUI.Test.Components
{
    public class TextBlock<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.TextBlock
        where TElement : Core.MockUI.Test.Elements.TextBlock, new()
    {
        public override void AssignProperties(ISharpCreator<Core.MockUI.Test.Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            //Element.Text = nextProps.Text;
        }
    }
}
