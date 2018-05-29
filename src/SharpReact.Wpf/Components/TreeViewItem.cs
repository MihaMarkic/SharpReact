
namespace SharpReact.Wpf.Components
{
	public  class TreeViewItem<TProps, TElement>: HeaderedItemsControl<TProps, TElement>
		where TProps : Props.TreeViewItem
		where TElement : System.Windows.Controls.TreeViewItem
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.TreeViewItem();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsExpanded.HasValue)
			{
				Element.IsExpanded = nextProps.IsExpanded.Value.Value;
			}
			if (nextProps.IsSelected.HasValue)
			{
				Element.IsSelected = nextProps.IsSelected.Value.Value;
			}
			if (!ReferenceEquals(Props?.Expanded, null) && ReferenceEquals(nextProps.Expanded, null))
			{
				Element.Expanded -= nextProps.Expanded;
			}
			if (ReferenceEquals(Props?.Expanded, null) && !ReferenceEquals(nextProps.Expanded, null))
			{
				Element.Expanded += nextProps.Expanded;
			}
			if (!ReferenceEquals(Props?.Collapsed, null) && ReferenceEquals(nextProps.Collapsed, null))
			{
				Element.Collapsed -= nextProps.Collapsed;
			}
			if (ReferenceEquals(Props?.Collapsed, null) && !ReferenceEquals(nextProps.Collapsed, null))
			{
				Element.Collapsed += nextProps.Collapsed;
			}
			if (!ReferenceEquals(Props?.Selected, null) && ReferenceEquals(nextProps.Selected, null))
			{
				Element.Selected -= nextProps.Selected;
			}
			if (ReferenceEquals(Props?.Selected, null) && !ReferenceEquals(nextProps.Selected, null))
			{
				Element.Selected += nextProps.Selected;
			}
			if (!ReferenceEquals(Props?.Unselected, null) && ReferenceEquals(nextProps.Unselected, null))
			{
				Element.Unselected -= nextProps.Unselected;
			}
			if (ReferenceEquals(Props?.Unselected, null) && !ReferenceEquals(nextProps.Unselected, null))
			{
				Element.Unselected += nextProps.Unselected;
			}
		}
	}
}
