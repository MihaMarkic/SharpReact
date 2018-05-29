
namespace SharpReact.Wpf.Components
{
	public  class StatusBar<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.StatusBar
		where TElement : System.Windows.Controls.Primitives.StatusBar
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.StatusBar();
		}
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
