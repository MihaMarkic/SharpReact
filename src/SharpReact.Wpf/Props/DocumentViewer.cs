using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DocumentViewer: DocumentViewerBase
	{
		public ReactParam<System.Double>? HorizontalOffset { get; set; }
		public ReactParam<System.Double>? VerticalOffset { get; set; }
		public ReactParam<System.Boolean>? ShowPageBorders { get; set; }
		public ReactParam<System.Double>? Zoom { get; set; }
		public ReactParam<System.Int32>? MaxPagesAcross { get; set; }
		public ReactParam<System.Double>? VerticalPageSpacing { get; set; }
		public ReactParam<System.Double>? HorizontalPageSpacing { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DocumentViewer<DocumentViewer, System.Windows.Controls.DocumentViewer>();
		}
	}
}
