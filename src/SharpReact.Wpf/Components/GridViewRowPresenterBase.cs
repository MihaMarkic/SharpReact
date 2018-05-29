
namespace SharpReact.Wpf.Components
{
	public abstract class GridViewRowPresenterBase<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.GridViewRowPresenterBase
		where TElement : System.Windows.Controls.Primitives.GridViewRowPresenterBase
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Columns.HasValue)
			{
				Element.Columns = nextProps.Columns.Value.Value;
			}
		}
	}
}
