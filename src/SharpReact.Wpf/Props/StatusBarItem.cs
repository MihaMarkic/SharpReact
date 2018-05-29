using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class StatusBarItem: ContentControl
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.StatusBarItem<StatusBarItem, System.Windows.Controls.Primitives.StatusBarItem>();
		}
	}
}
