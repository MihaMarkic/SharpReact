using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ResizeGrip: Control
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ResizeGrip<ResizeGrip, System.Windows.Controls.Primitives.ResizeGrip>();
		}
	}
}
