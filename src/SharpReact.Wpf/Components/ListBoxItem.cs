
namespace SharpReact.Wpf.Components
{
	public  class ListBoxItem<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.ListBoxItem
		where TElement : System.Windows.Controls.ListBoxItem
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ListBoxItem();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsSelected.HasValue)
			{
				Element.IsSelected = nextProps.IsSelected.Value.Value;
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
