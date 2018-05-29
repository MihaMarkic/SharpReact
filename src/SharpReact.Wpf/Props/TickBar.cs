using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class TickBar: FrameworkElement
	{
		public ReactParam<System.Windows.Media.Brush>? Fill { get; set; }
		public ReactParam<System.Double>? Minimum { get; set; }
		public ReactParam<System.Double>? Maximum { get; set; }
		public ReactParam<System.Double>? SelectionStart { get; set; }
		public ReactParam<System.Double>? SelectionEnd { get; set; }
		public ReactParam<System.Boolean>? IsSelectionRangeEnabled { get; set; }
		public ReactParam<System.Double>? TickFrequency { get; set; }
		public ReactParam<System.Windows.Media.DoubleCollection>? Ticks { get; set; }
		public ReactParam<System.Boolean>? IsDirectionReversed { get; set; }
		public ReactParam<System.Windows.Controls.Primitives.TickBarPlacement>? Placement { get; set; }
		public ReactParam<System.Double>? ReservedSpace { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TickBar<TickBar, System.Windows.Controls.Primitives.TickBar>();
		}
	}
}
