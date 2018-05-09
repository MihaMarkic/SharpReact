
namespace SharpReact.Wpf.Components
{
    public class StackPanel<TProps, TElement> : Panel<TProps, TElement>
        where TProps : Props.StackPanel
        where TElement : System.Windows.Controls.StackPanel, new()
    {
        public override void AssignProperties(TProps nextProps)
        {
            base.AssignProperties(nextProps);
            if (nextProps.Focusable.HasValue)
            {
                Element.Focusable = nextProps.Focusable.Value;
            }
            if (nextProps.Orientation.HasValue)
            {
                Element.Orientation = nextProps.Orientation.Value;
            }
        }
    }
}
