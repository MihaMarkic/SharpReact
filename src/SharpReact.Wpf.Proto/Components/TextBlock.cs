
using System.Windows;
using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
    public class TextBlock<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.TextBlock
        where TElement : System.Windows.Controls.TextBlock, new()
    {
        public override void AssignProperties(ISharpCreator<UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            Element.Text = nextProps.Text;
        }
    }
}
