using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class TreeView<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.TreeView
		where TElement : System.Windows.Controls.TreeView, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.SelectedValuePath.HasValue)
			{
				Element.SelectedValuePath = nextProps.SelectedValuePath.Value.Value;
			}
			if (!ReferenceEquals(previous?.SelectedItemChanged, null) && ReferenceEquals(nextProps.SelectedItemChanged, null))
			{
				Element.SelectedItemChanged -= nextProps.SelectedItemChanged;
			}
			if (ReferenceEquals(previous?.SelectedItemChanged, null) && !ReferenceEquals(nextProps.SelectedItemChanged, null))
			{
				Element.SelectedItemChanged += nextProps.SelectedItemChanged;
			}
		}
	}
}
