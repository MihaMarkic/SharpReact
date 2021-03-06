using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class FlowDocumentScrollViewer<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.FlowDocumentScrollViewer
		where TElement : global::System.Windows.Controls.FlowDocumentScrollViewer, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Document.HasValue)
			{
				Element.Document = nextProps.Document.Value.Value;
			}
			if (nextProps.Zoom.HasValue)
			{
				Element.Zoom = nextProps.Zoom.Value.Value;
			}
			if (nextProps.MaxZoom.HasValue)
			{
				Element.MaxZoom = nextProps.MaxZoom.Value.Value;
			}
			if (nextProps.MinZoom.HasValue)
			{
				Element.MinZoom = nextProps.MinZoom.Value.Value;
			}
			if (nextProps.ZoomIncrement.HasValue)
			{
				Element.ZoomIncrement = nextProps.ZoomIncrement.Value.Value;
			}
			if (nextProps.IsSelectionEnabled.HasValue)
			{
				Element.IsSelectionEnabled = nextProps.IsSelectionEnabled.Value.Value;
			}
			if (nextProps.IsToolBarVisible.HasValue)
			{
				Element.IsToolBarVisible = nextProps.IsToolBarVisible.Value.Value;
			}
			if (nextProps.HorizontalScrollBarVisibility.HasValue)
			{
				Element.HorizontalScrollBarVisibility = nextProps.HorizontalScrollBarVisibility.Value.Value;
			}
			if (nextProps.VerticalScrollBarVisibility.HasValue)
			{
				Element.VerticalScrollBarVisibility = nextProps.VerticalScrollBarVisibility.Value.Value;
			}
			if (nextProps.SelectionBrush.HasValue)
			{
				Element.SelectionBrush = nextProps.SelectionBrush.Value.Value;
			}
			if (nextProps.SelectionOpacity.HasValue)
			{
				Element.SelectionOpacity = nextProps.SelectionOpacity.Value.Value;
			}
			if (nextProps.IsInactiveSelectionHighlightEnabled.HasValue)
			{
				Element.IsInactiveSelectionHighlightEnabled = nextProps.IsInactiveSelectionHighlightEnabled.Value.Value;
			}
		}
	}
}
