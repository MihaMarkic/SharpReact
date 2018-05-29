using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Ellipse: Shape
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Ellipse<Ellipse>();
		}
	}
}
