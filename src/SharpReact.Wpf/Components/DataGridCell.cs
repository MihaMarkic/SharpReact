
namespace SharpReact.Wpf.Components
{
	public  class DataGridCell<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.DataGridCell
		where TElement : System.Windows.Controls.DataGridCell
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.DataGridCell();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsEditing.HasValue)
			{
				Element.IsEditing = nextProps.IsEditing.Value.Value;
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
