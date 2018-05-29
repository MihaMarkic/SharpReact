using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGridColumnHeadersPresenter: ItemsControl
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGridColumnHeadersPresenter<DataGridColumnHeadersPresenter, System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter>();
		}
	}
}
