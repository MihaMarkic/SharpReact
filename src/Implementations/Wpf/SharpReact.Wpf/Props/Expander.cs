using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Expander: HeaderedContentControl
	{
		public ReactParam<global::System.Windows.Controls.ExpandDirection>? ExpandDirection { get; set; }
		public ReactParam<global::System.Boolean>? IsExpanded { get; set; }
		public System.Windows.RoutedEventHandler Expanded { get; set; }
		public System.Windows.RoutedEventHandler Collapsed { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Expander<Expander, System.Windows.Controls.Expander>();
		}
	}
}
