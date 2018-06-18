using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class GridViewRowPresenterBase<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.GridViewRowPresenterBase
		where TElement : global::System.Windows.Controls.Primitives.GridViewRowPresenterBase, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Columns.HasValue)
			{
				Element.Columns = nextProps.Columns.Value.Value;
			}
		}
	}
}
