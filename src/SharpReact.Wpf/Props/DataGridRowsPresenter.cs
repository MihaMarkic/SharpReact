using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGridRowsPresenter: VirtualizingStackPanel
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGridRowsPresenter<DataGridRowsPresenter, System.Windows.Controls.Primitives.DataGridRowsPresenter>();
		}
	}
}
