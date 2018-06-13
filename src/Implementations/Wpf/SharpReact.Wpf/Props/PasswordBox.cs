using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class PasswordBox: Control
	{
		public ReactParam<global::System.String>? Password { get; set; }
		public ReactParam<global::System.Char>? PasswordChar { get; set; }
		public ReactParam<global::System.Int32>? MaxLength { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? SelectionBrush { get; set; }
		public ReactParam<global::System.Double>? SelectionOpacity { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? CaretBrush { get; set; }
		public ReactParam<global::System.Boolean>? IsInactiveSelectionHighlightEnabled { get; set; }
		public System.Windows.RoutedEventHandler PasswordChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.PasswordBox<PasswordBox>();
		}
	}
}
