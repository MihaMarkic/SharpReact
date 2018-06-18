using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class StatusBar<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.StatusBar
		where TElement : global::System.Windows.Controls.Primitives.StatusBar, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ItemContainerTemplateSelector.HasValue)
			{
				Element.ItemContainerTemplateSelector = nextProps.ItemContainerTemplateSelector.Value.Value;
			}
			if (nextProps.UsesItemContainerTemplate.HasValue)
			{
				Element.UsesItemContainerTemplate = nextProps.UsesItemContainerTemplate.Value.Value;
			}
		}
	}
}
