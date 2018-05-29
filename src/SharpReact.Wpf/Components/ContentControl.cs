
namespace SharpReact.Wpf.Components
{
	public  class ContentControl<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.ContentControl
		where TElement : System.Windows.Controls.ContentControl
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ContentControl();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
