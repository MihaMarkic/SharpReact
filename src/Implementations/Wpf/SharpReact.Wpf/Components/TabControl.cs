using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class TabControl<TProps, TElement>: Selector<TProps, TElement>
		where TProps : Props.TabControl
		where TElement : global::System.Windows.Controls.TabControl, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
