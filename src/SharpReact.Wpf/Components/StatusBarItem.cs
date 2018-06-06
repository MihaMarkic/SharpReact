using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class StatusBarItem<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.StatusBarItem
		where TElement : System.Windows.Controls.Primitives.StatusBarItem, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
