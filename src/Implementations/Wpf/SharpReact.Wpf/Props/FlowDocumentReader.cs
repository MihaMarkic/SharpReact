using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class FlowDocumentReader: Control
	{
		public ReactParam<global::System.Windows.Controls.FlowDocumentReaderViewingMode>? ViewingMode { get; set; }
		public ReactParam<global::System.Boolean>? IsPageViewEnabled { get; set; }
		public ReactParam<global::System.Boolean>? IsTwoPageViewEnabled { get; set; }
		public ReactParam<global::System.Boolean>? IsScrollViewEnabled { get; set; }
		public ReactParam<global::System.Boolean>? IsFindEnabled { get; set; }
		public ReactParam<global::System.Boolean>? IsPrintEnabled { get; set; }
		public ReactParam<global::System.Windows.Documents.FlowDocument>? Document { get; set; }
		public ReactParam<global::System.Double>? Zoom { get; set; }
		public ReactParam<global::System.Double>? MaxZoom { get; set; }
		public ReactParam<global::System.Double>? MinZoom { get; set; }
		public ReactParam<global::System.Double>? ZoomIncrement { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? SelectionBrush { get; set; }
		public ReactParam<global::System.Double>? SelectionOpacity { get; set; }
		public ReactParam<global::System.Boolean>? IsInactiveSelectionHighlightEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FlowDocumentReader<FlowDocumentReader, System.Windows.Controls.FlowDocumentReader>();
		}
	}
}
