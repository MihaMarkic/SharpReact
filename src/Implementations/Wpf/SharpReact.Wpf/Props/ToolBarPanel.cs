using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ToolBarPanel: StackPanel
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ToolBarPanel<ToolBarPanel, System.Windows.Controls.Primitives.ToolBarPanel>();
		}
	}
}
