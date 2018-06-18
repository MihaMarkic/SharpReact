using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class GridViewRowPresenter<TProps, TElement>: GridViewRowPresenterBase<TProps, TElement>
		where TProps : Props.GridViewRowPresenter
		where TElement : global::System.Windows.Controls.GridViewRowPresenter, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Content != null)
			{
				Element.Content = renderer.ProcessPair(level + 1, newState, previous?.Content, nextProps.Content);
			}
		}
	}
}
