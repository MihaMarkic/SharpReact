using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class DocumentViewerBase: Control
	{
		public ReactParam<global::System.Windows.Documents.IDocumentPaginatorSource>? Document { get; set; }
		public System.EventHandler PageViewsChanged { get; set; }
	}
}
