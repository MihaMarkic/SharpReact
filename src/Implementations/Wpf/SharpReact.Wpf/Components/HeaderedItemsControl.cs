using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class HeaderedItemsControl<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.HeaderedItemsControl
		where TElement : global::System.Windows.Controls.HeaderedItemsControl, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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