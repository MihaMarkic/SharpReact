using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class RangeBase: Control
	{
		public ReactParam<System.Double>? Minimum { get; set; }
		public ReactParam<System.Double>? Maximum { get; set; }
		public ReactParam<System.Double>? Value { get; set; }
		public ReactParam<System.Double>? LargeChange { get; set; }
		public ReactParam<System.Double>? SmallChange { get; set; }
		public System.Windows.RoutedPropertyChangedEventHandler<System.Double> ValueChanged { get; set; }
	}
}
