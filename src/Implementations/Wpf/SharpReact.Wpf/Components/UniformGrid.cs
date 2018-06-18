using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class UniformGrid<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.UniformGrid
		where TElement : global::System.Windows.Controls.Primitives.UniformGrid, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.FirstColumn.HasValue)
			{
				Element.FirstColumn = nextProps.FirstColumn.Value.Value;
			}
			if (nextProps.Columns.HasValue)
			{
				Element.Columns = nextProps.Columns.Value.Value;
			}
			if (nextProps.Rows.HasValue)
			{
				Element.Rows = nextProps.Rows.Value.Value;
			}
		}
	}
}
