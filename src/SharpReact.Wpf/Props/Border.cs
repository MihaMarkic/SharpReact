using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Border: Decorator
	{
		public ReactParam<System.Windows.Thickness>? BorderThickness { get; set; }
		public ReactParam<System.Windows.Thickness>? Padding { get; set; }
		public ReactParam<System.Windows.CornerRadius>? CornerRadius { get; set; }
		public ReactParam<System.Windows.Media.Brush>? BorderBrush { get; set; }
		public ReactParam<System.Windows.Media.Brush>? Background { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Border<Border, System.Windows.Controls.Border>();
		}
	}
}
