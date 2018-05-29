
namespace SharpReact.Wpf.Components
{
	public  class ScrollContentPresenter<TProps>: ContentPresenter<TProps, System.Windows.Controls.ScrollContentPresenter>
		where TProps : Props.ScrollContentPresenter
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Controls.ScrollContentPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.CanContentScroll.HasValue)
			{
				Element.CanContentScroll = nextProps.CanContentScroll.Value.Value;
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
