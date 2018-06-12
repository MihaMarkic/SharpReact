using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Rectangle: Shape
	{
		public ReactParam<global::System.Double>? RadiusX { get; set; }
		public ReactParam<global::System.Double>? RadiusY { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Rectangle<Rectangle>();
		}
	}
}
