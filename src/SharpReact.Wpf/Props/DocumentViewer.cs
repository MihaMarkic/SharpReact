using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DocumentViewer: DocumentViewerBase
	{
		public ReactParam<global::System.Double>? HorizontalOffset { get; set; }
		public ReactParam<global::System.Double>? VerticalOffset { get; set; }
		public ReactParam<global::System.Boolean>? ShowPageBorders { get; set; }
		public ReactParam<global::System.Double>? Zoom { get; set; }
		public ReactParam<global::System.Int32>? MaxPagesAcross { get; set; }
		public ReactParam<global::System.Double>? VerticalPageSpacing { get; set; }
		public ReactParam<global::System.Double>? HorizontalPageSpacing { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DocumentViewer<DocumentViewer, System.Windows.Controls.DocumentViewer>();
		}
	}
}
