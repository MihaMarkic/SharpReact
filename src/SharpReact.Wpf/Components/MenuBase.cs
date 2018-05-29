
namespace SharpReact.Wpf.Components
{
	public abstract class MenuBase<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.MenuBase
		where TElement : System.Windows.Controls.Primitives.MenuBase
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
