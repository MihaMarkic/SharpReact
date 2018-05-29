using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class RichTextBox: TextBoxBase
	{
		public ReactParam<System.Windows.Documents.FlowDocument>? Document { get; set; }
		public ReactParam<System.Boolean>? IsDocumentEnabled { get; set; }
		public ReactParam<System.Windows.Documents.TextPointer>? CaretPosition { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RichTextBox<RichTextBox, System.Windows.Controls.RichTextBox>();
		}
	}
}
