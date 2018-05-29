
namespace SharpReact.Wpf.Components
{
	public  class Popup<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Popup
		where TElement : System.Windows.Controls.Primitives.Popup
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.Popup();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Child.HasValue)
			{
				Element.Child = nextProps.Child.Value.Value;
			}
			if (nextProps.IsOpen.HasValue)
			{
				Element.IsOpen = nextProps.IsOpen.Value.Value;
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
			if (nextProps.HorizontalOffset.HasValue)
			{
				Element.HorizontalOffset = nextProps.HorizontalOffset.Value.Value;
			}
			if (nextProps.VerticalOffset.HasValue)
			{
				Element.VerticalOffset = nextProps.VerticalOffset.Value.Value;
			}
			if (nextProps.PlacementTarget.HasValue)
			{
				Element.PlacementTarget = nextProps.PlacementTarget.Value.Value;
			}
			if (nextProps.PlacementRectangle.HasValue)
			{
				Element.PlacementRectangle = nextProps.PlacementRectangle.Value.Value;
			}
			if (nextProps.PopupAnimation.HasValue)
			{
				Element.PopupAnimation = nextProps.PopupAnimation.Value.Value;
			}
			if (nextProps.AllowsTransparency.HasValue)
			{
				Element.AllowsTransparency = nextProps.AllowsTransparency.Value.Value;
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
