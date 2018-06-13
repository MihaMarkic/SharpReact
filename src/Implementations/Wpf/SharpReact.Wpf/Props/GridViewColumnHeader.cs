using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class GridViewColumnHeader: ButtonBase
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GridViewColumnHeader<GridViewColumnHeader, System.Windows.Controls.GridViewColumnHeader>();
		}
	}
}
