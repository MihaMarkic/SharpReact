using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class ButtonBase: ContentControl
	{
		public ReactParam<System.Windows.Input.ICommand>? Command { get; set; }
		public ReactParam<System.Object>? CommandParameter { get; set; }
		public ReactParam<System.Windows.IInputElement>? CommandTarget { get; set; }
		public ReactParam<System.Windows.Controls.ClickMode>? ClickMode { get; set; }
		public System.Windows.RoutedEventHandler Click { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			throw new System.NotImplementedException();
		}
	}
}
