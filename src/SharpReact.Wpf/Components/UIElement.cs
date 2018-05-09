
namespace SharpReact.Wpf.Components
{
    public class UIElement<TProps, TElement> : SharpWpfComponent<TProps, object, TElement>
        where TProps : Props.UIElement
        where TElement : System.Windows.UIElement, new()
    {
        public override void AssignProperties(TProps nextProps)
        {
            base.AssignProperties(nextProps);
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
