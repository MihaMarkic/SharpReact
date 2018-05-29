
namespace SharpReact.Wpf.Components
{
    public class Control<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.Control
        where TElement : System.Windows.Controls.Control, new()
    {
        public override void AssignProperties(TProps nextProps)
        {
            base.AssignProperties(nextProps);
            if (nextProps.FontSize.HasValue)
            {
                Element.FontSize = nextProps.FontSize.Value;
            }
        }
    }
}
