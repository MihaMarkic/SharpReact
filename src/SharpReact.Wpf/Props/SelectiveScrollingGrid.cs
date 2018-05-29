using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class SelectiveScrollingGrid: Grid
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.SelectiveScrollingGrid<SelectiveScrollingGrid, System.Windows.Controls.Primitives.SelectiveScrollingGrid>();
		}
	}
}
