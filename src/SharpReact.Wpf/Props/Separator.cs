using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Separator: Control
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Separator<Separator, System.Windows.Controls.Separator>();
		}
	}
}
