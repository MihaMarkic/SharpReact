
using System.Windows;
using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
    public abstract class TextBoxBase<TProps, TElement> : Control<TProps, TElement>
        where TProps : Props.TextBoxBase
        where TElement : System.Windows.Controls.Primitives.TextBoxBase, new()
    {
        public override void AssignProperties(ISharpCreator<UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (nextProps.IsReadOnly.HasValue)
            {
                Element.IsReadOnly = nextProps.IsReadOnly.Value;
            }
        }
    }
}
