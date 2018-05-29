
namespace SharpReact.Wpf.Components
{
	public  class TreeView<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.TreeView
		where TElement : System.Windows.Controls.TreeView
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.TreeView();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.SelectedValuePath.HasValue)
			{
				Element.SelectedValuePath = nextProps.SelectedValuePath.Value.Value;
			}
			if (!ReferenceEquals(Props?.SelectedItemChanged, null) && ReferenceEquals(nextProps.SelectedItemChanged, null))
			{
				Element.SelectedItemChanged -= nextProps.SelectedItemChanged;
			}
			if (ReferenceEquals(Props?.SelectedItemChanged, null) && !ReferenceEquals(nextProps.SelectedItemChanged, null))
			{
				Element.SelectedItemChanged += nextProps.SelectedItemChanged;
			}
		}
	}
}
