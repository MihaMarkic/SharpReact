using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Polygon: Shape
	{
		public ReactParam<System.Windows.Media.PointCollection>? Points { get; set; }
		public ReactParam<System.Windows.Media.FillRule>? FillRule { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Polygon<Polygon>();
		}
	}
}
