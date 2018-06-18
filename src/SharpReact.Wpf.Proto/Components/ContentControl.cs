
using System.Windows;
using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
    public class ContentControl<TProps, TElement> : Control<TProps, TElement>
        where TProps : Props.ContentControl
        where TElement : System.Windows.Controls.ContentControl, new()
    {
        public override void AssignProperties(ISharpRenderer<UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (nextProps.Content != null)
            {
                Element.Content = renderer.ProcessPair(level + 1, newState, Element, previous?.Content, nextProps.Content);
            }
        }
    }
}
