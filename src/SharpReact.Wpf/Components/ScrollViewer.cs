using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ScrollViewer<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.ScrollViewer
		where TElement : System.Windows.Controls.ScrollViewer, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.CanContentScroll.HasValue)
			{
				Element.CanContentScroll = nextProps.CanContentScroll.Value.Value;
			}
			if (nextProps.HorizontalScrollBarVisibility.HasValue)
			{
				Element.HorizontalScrollBarVisibility = nextProps.HorizontalScrollBarVisibility.Value.Value;
			}
			if (nextProps.VerticalScrollBarVisibility.HasValue)
			{
				Element.VerticalScrollBarVisibility = nextProps.VerticalScrollBarVisibility.Value.Value;
			}
			if (nextProps.IsDeferredScrollingEnabled.HasValue)
			{
				Element.IsDeferredScrollingEnabled = nextProps.IsDeferredScrollingEnabled.Value.Value;
			}
			if (nextProps.PanningMode.HasValue)
			{
				Element.PanningMode = nextProps.PanningMode.Value.Value;
			}
			if (nextProps.PanningDeceleration.HasValue)
			{
				Element.PanningDeceleration = nextProps.PanningDeceleration.Value.Value;
			}
			if (nextProps.PanningRatio.HasValue)
			{
				Element.PanningRatio = nextProps.PanningRatio.Value.Value;
			}
			if (!ReferenceEquals(Props?.ScrollChanged, null) && ReferenceEquals(nextProps.ScrollChanged, null))
			{
				Element.ScrollChanged -= nextProps.ScrollChanged;
			}
			if (ReferenceEquals(Props?.ScrollChanged, null) && !ReferenceEquals(nextProps.ScrollChanged, null))
			{
				Element.ScrollChanged += nextProps.ScrollChanged;
			}
		}
	}
}
