using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DataGridRowsPresenter<TProps, TElement>: VirtualizingStackPanel<TProps, TElement>
		where TProps : Props.DataGridRowsPresenter
		where TElement : global::System.Windows.Controls.Primitives.DataGridRowsPresenter, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
