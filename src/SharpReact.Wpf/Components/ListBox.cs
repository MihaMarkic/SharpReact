using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ListBox<TProps, TElement>: Selector<TProps, TElement>
		where TProps : Props.ListBox
		where TElement : System.Windows.Controls.ListBox, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.SelectionMode.HasValue)
			{
				Element.SelectionMode = nextProps.SelectionMode.Value.Value;
			}
		}
	}
}
