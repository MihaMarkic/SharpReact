using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class MenuBase<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.MenuBase
		where TElement : global::System.Windows.Controls.Primitives.MenuBase, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
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
