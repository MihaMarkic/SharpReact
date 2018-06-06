
using System.Windows;
using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
    public class Control<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.Control
        where TElement : System.Windows.Controls.Control, new()
    {
        public override void AssignProperties(ISharpCreator<UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (nextProps.FontSize.HasValue)
            {
                Element.FontSize = nextProps.FontSize.Value;
            }
        }
    }
}
