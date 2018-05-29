
namespace SharpReact.Wpf.Components
{
	public  class FlowDocumentPageViewer<TProps, TElement>: DocumentViewerBase<TProps, TElement>
		where TProps : Props.FlowDocumentPageViewer
		where TElement : System.Windows.Controls.FlowDocumentPageViewer
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.FlowDocumentPageViewer();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
