using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class StatusBarItem<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.StatusBarItem
		where TElement : global::System.Windows.Controls.Primitives.StatusBarItem, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
