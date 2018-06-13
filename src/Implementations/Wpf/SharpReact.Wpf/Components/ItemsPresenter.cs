using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ItemsPresenter<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.ItemsPresenter
		where TElement : global::System.Windows.Controls.ItemsPresenter, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
