
namespace SharpReact.Wpf.Components
{
	public  class TabControl<TProps, TElement>: Selector<TProps, TElement>
		where TProps : Props.TabControl
		where TElement : System.Windows.Controls.TabControl
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.TabControl();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.TabStripPlacement.HasValue)
			{
				Element.TabStripPlacement = nextProps.TabStripPlacement.Value.Value;
			}
			if (nextProps.ContentTemplate.HasValue)
			{
				Element.ContentTemplate = nextProps.ContentTemplate.Value.Value;
			}
			if (nextProps.ContentTemplateSelector.HasValue)
			{
				Element.ContentTemplateSelector = nextProps.ContentTemplateSelector.Value.Value;
			}
			if (nextProps.ContentStringFormat.HasValue)
			{
				Element.ContentStringFormat = nextProps.ContentStringFormat.Value.Value;
			}
		}
	}
}
