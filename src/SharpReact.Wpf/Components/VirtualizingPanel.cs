
namespace SharpReact.Wpf.Components
{
	public abstract class VirtualizingPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.VirtualizingPanel
		where TElement : System.Windows.Controls.VirtualizingPanel
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
