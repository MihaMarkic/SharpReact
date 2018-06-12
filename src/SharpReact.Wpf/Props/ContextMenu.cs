using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ContextMenu: MenuBase
	{
		public ReactParam<global::System.Double>? HorizontalOffset { get; set; }
		public ReactParam<global::System.Double>? VerticalOffset { get; set; }
		public ReactParam<global::System.Boolean>? IsOpen { get; set; }
		public ReactParam<global::System.Windows.UIElement>? PlacementTarget { get; set; }
		public ReactParam<global::System.Windows.Rect>? PlacementRectangle { get; set; }
		public ReactParam<global::System.Windows.Controls.Primitives.PlacementMode>? Placement { get; set; }
		public ReactParam<global::System.Boolean>? HasDropShadow { get; set; }
		public ReactParam<global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback>? CustomPopupPlacementCallback { get; set; }
		public ReactParam<global::System.Boolean>? StaysOpen { get; set; }
		public System.Windows.RoutedEventHandler Opened { get; set; }
		public System.Windows.RoutedEventHandler Closed { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ContextMenu<ContextMenu, System.Windows.Controls.ContextMenu>();
		}
	}
}
