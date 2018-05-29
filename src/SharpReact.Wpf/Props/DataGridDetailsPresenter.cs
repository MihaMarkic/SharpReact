using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGridDetailsPresenter: ContentPresenter
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGridDetailsPresenter<DataGridDetailsPresenter, System.Windows.Controls.Primitives.DataGridDetailsPresenter>();
		}
	}
}
