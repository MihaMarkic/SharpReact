using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Polyline: Shape
	{
		public ReactParam<global::System.Windows.Media.PointCollection>? Points { get; set; }
		public ReactParam<global::System.Windows.Media.FillRule>? FillRule { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Polyline<Polyline>();
		}
	}
}
