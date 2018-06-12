using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ToggleButton: ButtonBase
	{
		public ReactParam<global::System.Nullable<System.Boolean>>? IsChecked { get; set; }
		public ReactParam<global::System.Boolean>? IsThreeState { get; set; }
		public System.Windows.RoutedEventHandler Checked { get; set; }
		public System.Windows.RoutedEventHandler Unchecked { get; set; }
		public System.Windows.RoutedEventHandler Indeterminate { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ToggleButton<ToggleButton, System.Windows.Controls.Primitives.ToggleButton>();
		}
	}
}
