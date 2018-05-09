namespace SharpReact.Wpf.Components
{
    public class FrameworkElement<TProps, TElement> : UIElement<TProps, TElement>
        where TProps : Props.FrameworkElement
        where TElement : System.Windows.FrameworkElement, new()
    {
        public override void AssignProperties(TProps nextProps)
        {
            base.AssignProperties(nextProps);
            if (nextProps.HorizontalAlignment.HasValue)
            {
                Element.HorizontalAlignment = nextProps.HorizontalAlignment.Value;
            }
            if (nextProps.VerticalAlignment.HasValue)
            {
                Element.VerticalAlignment = nextProps.VerticalAlignment.Value;
            }
            if (nextProps.Margin.HasValue)
            {
                Element.Margin = nextProps.Margin.Value;
            }
        }
    }
}
