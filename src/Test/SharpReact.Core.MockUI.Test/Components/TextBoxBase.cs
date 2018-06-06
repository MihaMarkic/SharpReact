using SharpReact.Core;

namespace SharpReact.Core.MockUI.Test.Components
{
    public abstract class TextBoxBase<TProps, TElement> : Control<TProps, TElement>
        where TProps : Props.TextBoxBase
        where TElement : Core.MockUI.Test.Elements.TextBoxBase, new()
    {
        public override void AssignProperties(ISharpCreator<Core.MockUI.Test.Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            //if (nextProps.IsReadOnly.HasValue)
            //{
            //    Element.IsReadOnly = nextProps.IsReadOnly.Value;
            //}
        }
    }
}
