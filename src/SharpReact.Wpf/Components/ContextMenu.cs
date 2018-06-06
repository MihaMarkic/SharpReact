using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ContextMenu<TProps, TElement>: MenuBase<TProps, TElement>
		where TProps : Props.ContextMenu
		where TElement : System.Windows.Controls.ContextMenu, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
			if (nextProps.HasDropShadow.HasValue)
			{
				Element.HasDropShadow = nextProps.HasDropShadow.Value.Value;
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
