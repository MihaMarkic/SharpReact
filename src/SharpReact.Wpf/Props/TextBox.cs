using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class TextBox: TextBoxBase
	{
		public ReactParam<global::System.Windows.TextWrapping>? TextWrapping { get; set; }
		public ReactParam<global::System.Int32>? MinLines { get; set; }
		public ReactParam<global::System.Int32>? MaxLines { get; set; }
		public ReactParam<global::System.String>? Text { get; set; }
		public ReactParam<global::System.Windows.Controls.CharacterCasing>? CharacterCasing { get; set; }
		public ReactParam<global::System.Int32>? MaxLength { get; set; }
		public ReactParam<global::System.Windows.TextAlignment>? TextAlignment { get; set; }
		public ReactParam<global::System.String>? SelectedText { get; set; }
		public ReactParam<global::System.Int32>? SelectionLength { get; set; }
		public ReactParam<global::System.Int32>? SelectionStart { get; set; }
		public ReactParam<global::System.Int32>? CaretIndex { get; set; }
		public ReactParam<global::System.Windows.TextDecorationCollection>? TextDecorations { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TextBox<TextBox, System.Windows.Controls.TextBox>();
		}
	}
}
