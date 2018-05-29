
namespace SharpReact.Wpf.Components
{
	public  class DataGridRow<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.DataGridRow
		where TElement : System.Windows.Controls.DataGridRow
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.DataGridRow();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Item.HasValue)
			{
				Element.Item = nextProps.Item.Value.Value;
			}
			if (nextProps.ItemsPanel.HasValue)
			{
				Element.ItemsPanel = nextProps.ItemsPanel.Value.Value;
			}
			if (nextProps.Header.HasValue)
			{
				Element.Header = nextProps.Header.Value.Value;
			}
			if (nextProps.HeaderStyle.HasValue)
			{
				Element.HeaderStyle = nextProps.HeaderStyle.Value.Value;
			}
			if (nextProps.HeaderTemplate.HasValue)
			{
				Element.HeaderTemplate = nextProps.HeaderTemplate.Value.Value;
			}
			if (nextProps.HeaderTemplateSelector.HasValue)
			{
				Element.HeaderTemplateSelector = nextProps.HeaderTemplateSelector.Value.Value;
			}
			if (nextProps.ValidationErrorTemplate.HasValue)
			{
				Element.ValidationErrorTemplate = nextProps.ValidationErrorTemplate.Value.Value;
			}
			if (nextProps.DetailsTemplate.HasValue)
			{
				Element.DetailsTemplate = nextProps.DetailsTemplate.Value.Value;
			}
			if (nextProps.DetailsTemplateSelector.HasValue)
			{
				Element.DetailsTemplateSelector = nextProps.DetailsTemplateSelector.Value.Value;
			}
			if (nextProps.DetailsVisibility.HasValue)
			{
				Element.DetailsVisibility = nextProps.DetailsVisibility.Value.Value;
			}
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
