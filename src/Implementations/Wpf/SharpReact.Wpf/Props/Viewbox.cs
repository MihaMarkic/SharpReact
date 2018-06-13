using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Viewbox: Decorator
	{
		public ReactParam<global::System.Windows.UIElement>? Child { get; set; }
		public ReactParam<global::System.Windows.Media.Stretch>? Stretch { get; set; }
		public ReactParam<global::System.Windows.Controls.StretchDirection>? StretchDirection { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Viewbox<Viewbox, System.Windows.Controls.Viewbox>();
		}
	}
}
