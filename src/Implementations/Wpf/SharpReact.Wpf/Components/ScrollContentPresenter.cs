using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ScrollContentPresenter<TProps>: ContentPresenter<TProps, global::System.Windows.Controls.ScrollContentPresenter>
		where TProps : Props.ScrollContentPresenter
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
