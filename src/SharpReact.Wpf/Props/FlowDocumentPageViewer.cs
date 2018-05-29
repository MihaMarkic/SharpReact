using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class FlowDocumentPageViewer: DocumentViewerBase
	{
		public ReactParam<System.Double>? Zoom { get; set; }
		public ReactParam<System.Double>? MaxZoom { get; set; }
		public ReactParam<System.Double>? MinZoom { get; set; }
		public ReactParam<System.Double>? ZoomIncrement { get; set; }
		public ReactParam<System.Windows.Media.Brush>? SelectionBrush { get; set; }
		public ReactParam<System.Double>? SelectionOpacity { get; set; }
		public ReactParam<System.Boolean>? IsInactiveSelectionHighlightEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FlowDocumentPageViewer<FlowDocumentPageViewer, System.Windows.Controls.FlowDocumentPageViewer>();
		}
	}
}
