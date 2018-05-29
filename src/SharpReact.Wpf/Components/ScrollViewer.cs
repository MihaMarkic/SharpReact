
namespace SharpReact.Wpf.Components
{
	public  class ScrollViewer<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.ScrollViewer
		where TElement : System.Windows.Controls.ScrollViewer
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ScrollViewer();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
