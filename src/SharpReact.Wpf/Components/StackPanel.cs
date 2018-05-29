
namespace SharpReact.Wpf.Components
{
	public  class StackPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.StackPanel
		where TElement : System.Windows.Controls.StackPanel
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.StackPanel();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.CanHorizontallyScroll.HasValue)
			{
				Element.CanHorizontallyScroll = nextProps.CanHorizontallyScroll.Value.Value;
			}
			if (nextProps.CanVerticallyScroll.HasValue)
			{
				Element.CanVerticallyScroll = nextProps.CanVerticallyScroll.Value.Value;
			}
			if (nextProps.ScrollOwner.HasValue)
			{
				Element.ScrollOwner = nextProps.ScrollOwner.Value.Value;
			}
		}
	}
}
