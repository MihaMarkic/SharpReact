using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Grid: Panel
	{
		public ReactParam<global::System.Boolean>? ShowGridLines { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Grid<Grid, System.Windows.Controls.Grid>();
		}
	}
}
