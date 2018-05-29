
namespace SharpReact.Wpf.Components
{
	public abstract class ActiveXHost<TProps, TElement>: HwndHost<TProps, TElement>
		where TProps : Props.ActiveXHost
		where TElement : System.Windows.Interop.ActiveXHost
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
