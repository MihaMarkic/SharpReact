using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DocumentPageView: FrameworkElement
	{
		public ReactParam<global::System.Windows.Documents.DocumentPaginator>? DocumentPaginator { get; set; }
		public ReactParam<global::System.Int32>? PageNumber { get; set; }
		public ReactParam<global::System.Windows.Media.Stretch>? Stretch { get; set; }
		public ReactParam<global::System.Windows.Controls.StretchDirection>? StretchDirection { get; set; }
		public System.EventHandler PageConnected { get; set; }
		public System.EventHandler PageDisconnected { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DocumentPageView<DocumentPageView, System.Windows.Controls.Primitives.DocumentPageView>();
		}
	}
}
