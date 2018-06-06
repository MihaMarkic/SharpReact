using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ListViewItem<TProps, TElement>: ListBoxItem<TProps, TElement>
		where TProps : Props.ListViewItem
		where TElement : System.Windows.Controls.ListViewItem, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
