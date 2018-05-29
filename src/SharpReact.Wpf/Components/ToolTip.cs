
namespace SharpReact.Wpf.Components
{
	public  class ToolTip<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.ToolTip
		where TElement : System.Windows.Controls.ToolTip
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ToolTip();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.HorizontalOffset.HasValue)
			{
				Element.HorizontalOffset = nextProps.HorizontalOffset.Value.Value;
			}
			if (nextProps.VerticalOffset.HasValue)
			{
				Element.VerticalOffset = nextProps.VerticalOffset.Value.Value;
			}
			if (nextProps.IsOpen.HasValue)
			{
				Element.IsOpen = nextProps.IsOpen.Value.Value;
			}
			if (nextProps.HasDropShadow.HasValue)
			{
				Element.HasDropShadow = nextProps.HasDropShadow.Value.Value;
			}
			if (nextProps.PlacementTarget.HasValue)
			{
				Element.PlacementTarget = nextProps.PlacementTarget.Value.Value;
			}
			if (nextProps.PlacementRectangle.HasValue)
			{
				Element.PlacementRectangle = nextProps.PlacementRectangle.Value.Value;
			}
			if (nextProps.Placement.HasValue)
			{
				Element.Placement = nextProps.Placement.Value.Value;
			}
			if (nextProps.CustomPopupPlacementCallback.HasValue)
			{
				Element.CustomPopupPlacementCallback = nextProps.CustomPopupPlacementCallback.Value.Value;
			}
			if (nextProps.StaysOpen.HasValue)
			{
				Element.StaysOpen = nextProps.StaysOpen.Value.Value;
			}
			if (!ReferenceEquals(Props?.Opened, null) && ReferenceEquals(nextProps.Opened, null))
			{
				Element.Opened -= nextProps.Opened;
			}
			if (ReferenceEquals(Props?.Opened, null) && !ReferenceEquals(nextProps.Opened, null))
			{
				Element.Opened += nextProps.Opened;
			}
			if (!ReferenceEquals(Props?.Closed, null) && ReferenceEquals(nextProps.Closed, null))
			{
				Element.Closed -= nextProps.Closed;
			}
			if (ReferenceEquals(Props?.Closed, null) && !ReferenceEquals(nextProps.Closed, null))
			{
				Element.Closed += nextProps.Closed;
			}
		}
	}
}
