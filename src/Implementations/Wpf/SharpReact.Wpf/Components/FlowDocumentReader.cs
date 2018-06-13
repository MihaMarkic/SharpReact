using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class FlowDocumentReader<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.FlowDocumentReader
		where TElement : global::System.Windows.Controls.FlowDocumentReader, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ViewingMode.HasValue)
			{
				Element.ViewingMode = nextProps.ViewingMode.Value.Value;
			}
			if (nextProps.IsPageViewEnabled.HasValue)
			{
				Element.IsPageViewEnabled = nextProps.IsPageViewEnabled.Value.Value;
			}
			if (nextProps.IsTwoPageViewEnabled.HasValue)
			{
				Element.IsTwoPageViewEnabled = nextProps.IsTwoPageViewEnabled.Value.Value;
			}
			if (nextProps.IsScrollViewEnabled.HasValue)
			{
				Element.IsScrollViewEnabled = nextProps.IsScrollViewEnabled.Value.Value;
			}
			if (nextProps.IsFindEnabled.HasValue)
			{
				Element.IsFindEnabled = nextProps.IsFindEnabled.Value.Value;
			}
			if (nextProps.IsPrintEnabled.HasValue)
			{
				Element.IsPrintEnabled = nextProps.IsPrintEnabled.Value.Value;
			}
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
