using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGridCellsPresenter: ItemsControl
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGridCellsPresenter<DataGridCellsPresenter, System.Windows.Controls.Primitives.DataGridCellsPresenter>();
		}
	}
}
