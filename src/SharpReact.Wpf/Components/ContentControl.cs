using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ContentControl<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.ContentControl
		where TElement : System.Windows.Controls.ContentControl, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
		}
	}
}
