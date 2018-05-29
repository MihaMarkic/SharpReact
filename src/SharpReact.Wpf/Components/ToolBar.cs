
namespace SharpReact.Wpf.Components
{
	public  class ToolBar<TProps, TElement>: HeaderedItemsControl<TProps, TElement>
		where TProps : Props.ToolBar
		where TElement : System.Windows.Controls.ToolBar
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ToolBar();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Band.HasValue)
			{
				Element.Band = nextProps.Band.Value.Value;
			}
			if (nextProps.BandIndex.HasValue)
			{
				Element.BandIndex = nextProps.BandIndex.Value.Value;
			}
			if (nextProps.IsOverflowOpen.HasValue)
			{
				Element.IsOverflowOpen = nextProps.IsOverflowOpen.Value.Value;
			}
		}
	}
}
