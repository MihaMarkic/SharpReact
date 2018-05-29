using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Viewport3D: FrameworkElement
	{
		public ReactParam<System.Windows.Media.Media3D.Camera>? Camera { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Viewport3D<Viewport3D, System.Windows.Controls.Viewport3D>();
		}
	}
}
