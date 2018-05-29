using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ScrollViewer: ContentControl
	{
		public ReactParam<System.Boolean>? CanContentScroll { get; set; }
		public ReactParam<System.Windows.Controls.ScrollBarVisibility>? HorizontalScrollBarVisibility { get; set; }
		public ReactParam<System.Windows.Controls.ScrollBarVisibility>? VerticalScrollBarVisibility { get; set; }
		public ReactParam<System.Boolean>? IsDeferredScrollingEnabled { get; set; }
		public ReactParam<System.Windows.Controls.PanningMode>? PanningMode { get; set; }
		public ReactParam<System.Double>? PanningDeceleration { get; set; }
		public ReactParam<System.Double>? PanningRatio { get; set; }
		public System.Windows.Controls.ScrollChangedEventHandler ScrollChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ScrollViewer<ScrollViewer, System.Windows.Controls.ScrollViewer>();
		}
	}
}
