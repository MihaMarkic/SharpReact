using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class ButtonBase: ContentControl
	{
		public ReactParam<global::System.Windows.Input.ICommand>? Command { get; set; }
		public ReactParam<global::System.Object>? CommandParameter { get; set; }
		public ReactParam<global::System.Windows.IInputElement>? CommandTarget { get; set; }
		public ReactParam<global::System.Windows.Controls.ClickMode>? ClickMode { get; set; }
		public System.Windows.RoutedEventHandler Click { get; set; }
	}
}
