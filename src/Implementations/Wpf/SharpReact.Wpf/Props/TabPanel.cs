using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class TabPanel: Panel
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TabPanel<TabPanel, System.Windows.Controls.Primitives.TabPanel>();
		}
	}
}
