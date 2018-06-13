using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class SelectiveScrollingGrid<TProps, TElement>: Grid<TProps, TElement>
		where TProps : Props.SelectiveScrollingGrid
		where TElement : global::System.Windows.Controls.Primitives.SelectiveScrollingGrid, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
