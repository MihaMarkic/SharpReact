
using System.Windows;
using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
    public class UIElement<TProps, TElement> : SharpWpfComponent<TProps, object, TElement>
        where TProps : Props.UIElement
        where TElement : System.Windows.UIElement, new()
    {
        public override void AssignProperties(ISharpCreator<UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (nextProps.IsEnabled.HasValue)
            {
                Element.IsEnabled = nextProps.IsEnabled.Value;
            }
            if (nextProps.Visibility.HasValue)
            {
                Element.Visibility = nextProps.Visibility.Value;
            }
        }
    }
}
