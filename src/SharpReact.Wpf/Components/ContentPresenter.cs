
namespace SharpReact.Wpf.Components
{
	public  class ContentPresenter<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.ContentPresenter
		where TElement : System.Windows.Controls.ContentPresenter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ContentPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.RecognizesAccessKey.HasValue)
			{
				Element.RecognizesAccessKey = nextProps.RecognizesAccessKey.Value.Value;
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
			if (nextProps.ContentSource.HasValue)
			{
				Element.ContentSource = nextProps.ContentSource.Value.Value;
			}
		}
	}
}
