using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ListView<TProps, TElement>: ListBox<TProps, TElement>
		where TProps : Props.ListView
		where TElement : global::System.Windows.Controls.ListView, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.View.HasValue)
			{
				Element.View = nextProps.View.Value.Value;
			}
		}
	}
}
