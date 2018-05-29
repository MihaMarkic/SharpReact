using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Line: Shape
	{
		public ReactParam<System.Double>? X1 { get; set; }
		public ReactParam<System.Double>? Y1 { get; set; }
		public ReactParam<System.Double>? X2 { get; set; }
		public ReactParam<System.Double>? Y2 { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Line<Line>();
		}
	}
}
