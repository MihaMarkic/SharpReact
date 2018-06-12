using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class Shape: FrameworkElement
	{
		public ReactParam<global::System.Windows.Media.Stretch>? Stretch { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? Fill { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? Stroke { get; set; }
		public ReactParam<global::System.Double>? StrokeThickness { get; set; }
		public ReactParam<global::System.Windows.Media.PenLineCap>? StrokeStartLineCap { get; set; }
		public ReactParam<global::System.Windows.Media.PenLineCap>? StrokeEndLineCap { get; set; }
		public ReactParam<global::System.Windows.Media.PenLineCap>? StrokeDashCap { get; set; }
		public ReactParam<global::System.Windows.Media.PenLineJoin>? StrokeLineJoin { get; set; }
		public ReactParam<global::System.Double>? StrokeMiterLimit { get; set; }
		public ReactParam<global::System.Double>? StrokeDashOffset { get; set; }
		public ReactParam<global::System.Windows.Media.DoubleCollection>? StrokeDashArray { get; set; }
	}
}
