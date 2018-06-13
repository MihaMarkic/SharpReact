using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ToolBarTray: FrameworkElement
	{
		public ReactParam<global::System.Windows.Media.Brush>? Background { get; set; }
		public ReactParam<global::System.Windows.Controls.Orientation>? Orientation { get; set; }
		public ReactParam<global::System.Boolean>? IsLocked { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ToolBarTray<ToolBarTray, System.Windows.Controls.ToolBarTray>();
		}
	}
}
