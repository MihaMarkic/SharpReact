using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class FlowDocumentScrollViewer: Control
	{
		public ReactParam<global::System.Windows.Documents.FlowDocument>? Document { get; set; }
		public ReactParam<global::System.Double>? Zoom { get; set; }
		public ReactParam<global::System.Double>? MaxZoom { get; set; }
		public ReactParam<global::System.Double>? MinZoom { get; set; }
		public ReactParam<global::System.Double>? ZoomIncrement { get; set; }
		public ReactParam<global::System.Boolean>? IsSelectionEnabled { get; set; }
		public ReactParam<global::System.Boolean>? IsToolBarVisible { get; set; }
		public ReactParam<global::System.Windows.Controls.ScrollBarVisibility>? HorizontalScrollBarVisibility { get; set; }
		public ReactParam<global::System.Windows.Controls.ScrollBarVisibility>? VerticalScrollBarVisibility { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? SelectionBrush { get; set; }
		public ReactParam<global::System.Double>? SelectionOpacity { get; set; }
		public ReactParam<global::System.Boolean>? IsInactiveSelectionHighlightEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FlowDocumentScrollViewer<FlowDocumentScrollViewer, System.Windows.Controls.FlowDocumentScrollViewer>();
		}
	}
}
