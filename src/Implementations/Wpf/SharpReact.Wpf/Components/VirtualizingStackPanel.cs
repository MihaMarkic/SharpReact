using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class VirtualizingStackPanel<TProps, TElement>: VirtualizingPanel<TProps, TElement>
		where TProps : Props.VirtualizingStackPanel
		where TElement : global::System.Windows.Controls.VirtualizingStackPanel, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
