using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class FlowDocumentReader: Control
	{
		public ReactParam<System.Windows.Controls.FlowDocumentReaderViewingMode>? ViewingMode { get; set; }
		public ReactParam<System.Boolean>? IsPageViewEnabled { get; set; }
		public ReactParam<System.Boolean>? IsTwoPageViewEnabled { get; set; }
		public ReactParam<System.Boolean>? IsScrollViewEnabled { get; set; }
		public ReactParam<System.Boolean>? IsFindEnabled { get; set; }
		public ReactParam<System.Boolean>? IsPrintEnabled { get; set; }
		public ReactParam<System.Windows.Documents.FlowDocument>? Document { get; set; }
		public ReactParam<System.Double>? Zoom { get; set; }
		public ReactParam<System.Double>? MaxZoom { get; set; }
		public ReactParam<System.Double>? MinZoom { get; set; }
		public ReactParam<System.Double>? ZoomIncrement { get; set; }
		public ReactParam<System.Windows.Media.Brush>? SelectionBrush { get; set; }
		public ReactParam<System.Double>? SelectionOpacity { get; set; }
		public ReactParam<System.Boolean>? IsInactiveSelectionHighlightEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FlowDocumentReader<FlowDocumentReader, System.Windows.Controls.FlowDocumentReader>();
		}
	}
}
