
namespace SharpReact.Wpf.Components
{
    public class TextBlock<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.TextBlock
        where TElement : System.Windows.Controls.TextBlock, new()
    {
        public override void AssignProperties(TProps nextProps)
        {
            base.AssignProperties(nextProps);
            Element.Text = nextProps.Text;
        }
    }
}
