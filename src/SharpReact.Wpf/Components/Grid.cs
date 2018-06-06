using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Grid<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.Grid
		where TElement : System.Windows.Controls.Grid, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ShowGridLines.HasValue)
			{
				Element.ShowGridLines = nextProps.ShowGridLines.Value.Value;
			}
		}
	}
}
