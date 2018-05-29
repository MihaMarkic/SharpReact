
namespace SharpReact.Wpf.Components
{
	public abstract class AdornerLayer<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.AdornerLayer
		where TElement : System.Windows.Documents.AdornerLayer
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
