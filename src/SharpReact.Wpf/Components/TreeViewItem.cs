using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class TreeViewItem<TProps, TElement>: HeaderedItemsControl<TProps, TElement>
		where TProps : Props.TreeViewItem
		where TElement : System.Windows.Controls.TreeViewItem, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.IsExpanded.HasValue)
			{
				Element.IsExpanded = nextProps.IsExpanded.Value.Value;
			}
			if (nextProps.IsSelected.HasValue)
			{
				Element.IsSelected = nextProps.IsSelected.Value.Value;
			}
			if (!ReferenceEquals(previous?.Expanded, null) && ReferenceEquals(nextProps.Expanded, null))
			{
				Element.Expanded -= nextProps.Expanded;
			}
			if (ReferenceEquals(previous?.Expanded, null) && !ReferenceEquals(nextProps.Expanded, null))
			{
				Element.Expanded += nextProps.Expanded;
			}
			if (!ReferenceEquals(previous?.Collapsed, null) && ReferenceEquals(nextProps.Collapsed, null))
			{
				Element.Collapsed -= nextProps.Collapsed;
			}
			if (ReferenceEquals(previous?.Collapsed, null) && !ReferenceEquals(nextProps.Collapsed, null))
			{
				Element.Collapsed += nextProps.Collapsed;
			}
			if (!ReferenceEquals(previous?.Selected, null) && ReferenceEquals(nextProps.Selected, null))
			{
				Element.Selected -= nextProps.Selected;
			}
			if (ReferenceEquals(previous?.Selected, null) && !ReferenceEquals(nextProps.Selected, null))
			{
				Element.Selected += nextProps.Selected;
			}
			if (!ReferenceEquals(previous?.Unselected, null) && ReferenceEquals(nextProps.Unselected, null))
			{
				Element.Unselected -= nextProps.Unselected;
			}
			if (ReferenceEquals(previous?.Unselected, null) && !ReferenceEquals(nextProps.Unselected, null))
			{
				Element.Unselected += nextProps.Unselected;
			}
		}
	}
}
