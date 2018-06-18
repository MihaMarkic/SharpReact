using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DataGridDetailsPresenter<TProps, TElement>: ContentPresenter<TProps, TElement>
		where TProps : Props.DataGridDetailsPresenter
		where TElement : global::System.Windows.Controls.Primitives.DataGridDetailsPresenter, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
