using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class WrapPanel: Panel
	{
		public ReactParam<global::System.Double>? ItemWidth { get; set; }
		public ReactParam<global::System.Double>? ItemHeight { get; set; }
		public ReactParam<global::System.Windows.Controls.Orientation>? Orientation { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.WrapPanel<WrapPanel, System.Windows.Controls.WrapPanel>();
		}
	}
}
