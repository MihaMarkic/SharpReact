using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class RichTextBox: TextBoxBase
	{
		public ReactParam<global::System.Windows.Documents.FlowDocument>? Document { get; set; }
		public ReactParam<global::System.Boolean>? IsDocumentEnabled { get; set; }
		public ReactParam<global::System.Windows.Documents.TextPointer>? CaretPosition { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RichTextBox<RichTextBox, System.Windows.Controls.RichTextBox>();
		}
	}
}
