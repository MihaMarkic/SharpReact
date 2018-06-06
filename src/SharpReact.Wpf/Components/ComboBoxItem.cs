using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ComboBoxItem<TProps, TElement>: ListBoxItem<TProps, TElement>
		where TProps : Props.ComboBoxItem
		where TElement : System.Windows.Controls.ComboBoxItem, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
