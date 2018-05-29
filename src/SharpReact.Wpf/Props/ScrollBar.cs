using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ScrollBar: RangeBase
	{
		public ReactParam<System.Windows.Controls.Orientation>? Orientation { get; set; }
		public ReactParam<System.Double>? ViewportSize { get; set; }
		public System.Windows.Controls.Primitives.ScrollEventHandler Scroll { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ScrollBar<ScrollBar, System.Windows.Controls.Primitives.ScrollBar>();
		}
	}
}
