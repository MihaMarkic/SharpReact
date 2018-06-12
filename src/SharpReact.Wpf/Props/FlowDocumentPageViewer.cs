using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class FlowDocumentPageViewer: DocumentViewerBase
	{
		public ReactParam<global::System.Double>? Zoom { get; set; }
		public ReactParam<global::System.Double>? MaxZoom { get; set; }
		public ReactParam<global::System.Double>? MinZoom { get; set; }
		public ReactParam<global::System.Double>? ZoomIncrement { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? SelectionBrush { get; set; }
		public ReactParam<global::System.Double>? SelectionOpacity { get; set; }
		public ReactParam<global::System.Boolean>? IsInactiveSelectionHighlightEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FlowDocumentPageViewer<FlowDocumentPageViewer, System.Windows.Controls.FlowDocumentPageViewer>();
		}
	}
}
