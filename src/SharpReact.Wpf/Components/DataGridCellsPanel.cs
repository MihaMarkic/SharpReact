using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DataGridCellsPanel<TProps, TElement>: VirtualizingPanel<TProps, TElement>
		where TProps : Props.DataGridCellsPanel
		where TElement : System.Windows.Controls.DataGridCellsPanel, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
