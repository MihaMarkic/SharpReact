using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Popup: FrameworkElement
	{
		public ReactParam<System.Windows.UIElement>? Child { get; set; }
		public ReactParam<System.Boolean>? IsOpen { get; set; }
		public ReactParam<System.Windows.Controls.Primitives.PlacementMode>? Placement { get; set; }
		public ReactParam<System.Windows.Controls.Primitives.CustomPopupPlacementCallback>? CustomPopupPlacementCallback { get; set; }
		public ReactParam<System.Boolean>? StaysOpen { get; set; }
		public ReactParam<System.Double>? HorizontalOffset { get; set; }
		public ReactParam<System.Double>? VerticalOffset { get; set; }
		public ReactParam<System.Windows.UIElement>? PlacementTarget { get; set; }
		public ReactParam<System.Windows.Rect>? PlacementRectangle { get; set; }
		public ReactParam<System.Windows.Controls.Primitives.PopupAnimation>? PopupAnimation { get; set; }
		public ReactParam<System.Boolean>? AllowsTransparency { get; set; }
		public System.EventHandler Opened { get; set; }
		public System.EventHandler Closed { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Popup<Popup, System.Windows.Controls.Primitives.Popup>();
		}
	}
}
