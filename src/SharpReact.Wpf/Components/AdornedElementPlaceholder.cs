
namespace SharpReact.Wpf.Components
{
	public  class AdornedElementPlaceholder<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.AdornedElementPlaceholder
		where TElement : System.Windows.Controls.AdornedElementPlaceholder
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.AdornedElementPlaceholder();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Child.HasValue)
			{
				Element.Child = nextProps.Child.Value.Value;
			}
		}
	}
}
