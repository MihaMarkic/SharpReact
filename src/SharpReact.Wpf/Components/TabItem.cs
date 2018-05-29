
namespace SharpReact.Wpf.Components
{
	public  class TabItem<TProps, TElement>: HeaderedContentControl<TProps, TElement>
		where TProps : Props.TabItem
		where TElement : System.Windows.Controls.TabItem
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.TabItem();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsSelected.HasValue)
			{
				Element.IsSelected = nextProps.IsSelected.Value.Value;
			}
		}
	}
}
