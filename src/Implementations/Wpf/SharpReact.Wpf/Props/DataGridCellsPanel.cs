using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGridCellsPanel: VirtualizingPanel
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGridCellsPanel<DataGridCellsPanel, System.Windows.Controls.DataGridCellsPanel>();
		}
	}
}
