using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ToolBar: HeaderedItemsControl
	{
		public ReactParam<System.Int32>? Band { get; set; }
		public ReactParam<System.Int32>? BandIndex { get; set; }
		public ReactParam<System.Boolean>? IsOverflowOpen { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ToolBar<ToolBar, System.Windows.Controls.ToolBar>();
		}
	}
}
