using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ContentPresenter<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.ContentPresenter
		where TElement : global::System.Windows.Controls.ContentPresenter, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.RecognizesAccessKey.HasValue)
			{
				Element.RecognizesAccessKey = nextProps.RecognizesAccessKey.Value.Value;
			}
			if (nextProps.Content != null)
			{
				Element.Content = renderer.ProcessPair(level + 1, newState, previous?.Content, nextProps.Content);
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
