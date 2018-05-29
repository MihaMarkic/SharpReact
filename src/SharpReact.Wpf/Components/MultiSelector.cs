
namespace SharpReact.Wpf.Components
{
	public abstract class MultiSelector<TProps, TElement>: Selector<TProps, TElement>
		where TProps : Props.MultiSelector
		where TElement : System.Windows.Controls.Primitives.MultiSelector
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
