using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class TextBox: TextBoxBase
	{
		public ReactParam<System.Windows.TextWrapping>? TextWrapping { get; set; }
		public ReactParam<System.Int32>? MinLines { get; set; }
		public ReactParam<System.Int32>? MaxLines { get; set; }
		public ReactParam<System.String>? Text { get; set; }
		public ReactParam<System.Windows.Controls.CharacterCasing>? CharacterCasing { get; set; }
		public ReactParam<System.Int32>? MaxLength { get; set; }
		public ReactParam<System.Windows.TextAlignment>? TextAlignment { get; set; }
		public ReactParam<System.String>? SelectedText { get; set; }
		public ReactParam<System.Int32>? SelectionLength { get; set; }
		public ReactParam<System.Int32>? SelectionStart { get; set; }
		public ReactParam<System.Int32>? CaretIndex { get; set; }
		public ReactParam<System.Windows.TextDecorationCollection>? TextDecorations { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TextBox<TextBox, System.Windows.Controls.TextBox>();
		}
	}
}
