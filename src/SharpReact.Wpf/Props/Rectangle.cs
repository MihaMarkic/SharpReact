using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Rectangle: Shape
	{
		public ReactParam<System.Double>? RadiusX { get; set; }
		public ReactParam<System.Double>? RadiusY { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Rectangle<Rectangle>();
		}
	}
}
