using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DataGridColumnHeadersPresenter<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.DataGridColumnHeadersPresenter
		where TElement : global::System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
