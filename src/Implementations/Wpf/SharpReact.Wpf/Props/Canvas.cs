using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Canvas: Panel
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Canvas<Canvas, System.Windows.Controls.Canvas>();
		}
	}
}
