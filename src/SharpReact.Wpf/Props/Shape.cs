using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class Shape: FrameworkElement
	{
		public ReactParam<System.Windows.Media.Stretch>? Stretch { get; set; }
		public ReactParam<System.Windows.Media.Brush>? Fill { get; set; }
		public ReactParam<System.Windows.Media.Brush>? Stroke { get; set; }
		public ReactParam<System.Double>? StrokeThickness { get; set; }
		public ReactParam<System.Windows.Media.PenLineCap>? StrokeStartLineCap { get; set; }
		public ReactParam<System.Windows.Media.PenLineCap>? StrokeEndLineCap { get; set; }
		public ReactParam<System.Windows.Media.PenLineCap>? StrokeDashCap { get; set; }
		public ReactParam<System.Windows.Media.PenLineJoin>? StrokeLineJoin { get; set; }
		public ReactParam<System.Double>? StrokeMiterLimit { get; set; }
		public ReactParam<System.Double>? StrokeDashOffset { get; set; }
		public ReactParam<System.Windows.Media.DoubleCollection>? StrokeDashArray { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			throw new System.NotImplementedException();
		}
	}
}
