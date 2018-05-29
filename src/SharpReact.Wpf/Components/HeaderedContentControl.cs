
namespace SharpReact.Wpf.Components
{
	public  class HeaderedContentControl<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.HeaderedContentControl
		where TElement : System.Windows.Controls.HeaderedContentControl
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.HeaderedContentControl();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Header.HasValue)
			{
				Element.Header = nextProps.Header.Value.Value;
			}
			if (nextProps.HeaderTemplate.HasValue)
			{
				Element.HeaderTemplate = nextProps.HeaderTemplate.Value.Value;
			}
			if (nextProps.HeaderTemplateSelector.HasValue)
			{
				Element.HeaderTemplateSelector = nextProps.HeaderTemplateSelector.Value.Value;
			}
			if (nextProps.HeaderStringFormat.HasValue)
			{
				Element.HeaderStringFormat = nextProps.HeaderStringFormat.Value.Value;
			}
		}
	}
}
