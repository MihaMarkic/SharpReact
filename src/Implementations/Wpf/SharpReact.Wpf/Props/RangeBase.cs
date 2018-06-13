using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class RangeBase: Control
	{
		public ReactParam<global::System.Double>? Minimum { get; set; }
		public ReactParam<global::System.Double>? Maximum { get; set; }
		public ReactParam<global::System.Double>? Value { get; set; }
		public ReactParam<global::System.Double>? LargeChange { get; set; }
		public ReactParam<global::System.Double>? SmallChange { get; set; }
		public System.Windows.RoutedPropertyChangedEventHandler<global::System.Double> ValueChanged { get; set; }
	}
}
