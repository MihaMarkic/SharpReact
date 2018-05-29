using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Slider: RangeBase
	{
		public ReactParam<System.Windows.Controls.Orientation>? Orientation { get; set; }
		public ReactParam<System.Boolean>? IsDirectionReversed { get; set; }
		public ReactParam<System.Int32>? Delay { get; set; }
		public ReactParam<System.Int32>? Interval { get; set; }
		public ReactParam<System.Windows.Controls.Primitives.AutoToolTipPlacement>? AutoToolTipPlacement { get; set; }
		public ReactParam<System.Int32>? AutoToolTipPrecision { get; set; }
		public ReactParam<System.Boolean>? IsSnapToTickEnabled { get; set; }
		public ReactParam<System.Windows.Controls.Primitives.TickPlacement>? TickPlacement { get; set; }
		public ReactParam<System.Double>? TickFrequency { get; set; }
		public ReactParam<System.Windows.Media.DoubleCollection>? Ticks { get; set; }
		public ReactParam<System.Boolean>? IsSelectionRangeEnabled { get; set; }
		public ReactParam<System.Double>? SelectionStart { get; set; }
		public ReactParam<System.Double>? SelectionEnd { get; set; }
		public ReactParam<System.Boolean>? IsMoveToPointEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Slider<Slider, System.Windows.Controls.Slider>();
		}
	}
}
