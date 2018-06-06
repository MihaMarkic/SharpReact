using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class TextBoxBase: Control
	{
		public ReactParam<System.Boolean>? IsReadOnly { get; set; }
		public ReactParam<System.Boolean>? IsReadOnlyCaretVisible { get; set; }
		public ReactParam<System.Boolean>? AcceptsReturn { get; set; }
		public ReactParam<System.Boolean>? AcceptsTab { get; set; }
		public ReactParam<System.Windows.Controls.ScrollBarVisibility>? HorizontalScrollBarVisibility { get; set; }
		public ReactParam<System.Windows.Controls.ScrollBarVisibility>? VerticalScrollBarVisibility { get; set; }
		public ReactParam<System.Boolean>? IsUndoEnabled { get; set; }
		public ReactParam<System.Int32>? UndoLimit { get; set; }
		public ReactParam<System.Boolean>? AutoWordSelection { get; set; }
		public ReactParam<System.Windows.Media.Brush>? SelectionBrush { get; set; }
		public ReactParam<System.Double>? SelectionOpacity { get; set; }
		public ReactParam<System.Windows.Media.Brush>? CaretBrush { get; set; }
		public ReactParam<System.Boolean>? IsInactiveSelectionHighlightEnabled { get; set; }
		public System.Windows.Controls.TextChangedEventHandler TextChanged { get; set; }
		public System.Windows.RoutedEventHandler SelectionChanged { get; set; }
	}
}
