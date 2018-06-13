using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Path: Shape
	{
		public ReactParam<global::System.Windows.Media.Geometry>? Data { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Path<Path>();
		}
	}
}
