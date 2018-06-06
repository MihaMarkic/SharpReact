using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DataGridCellsPresenter<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.DataGridCellsPresenter
		where TElement : System.Windows.Controls.Primitives.DataGridCellsPresenter, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
