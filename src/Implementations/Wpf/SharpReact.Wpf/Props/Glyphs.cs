using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Glyphs: FrameworkElement
	{
		public ReactParam<global::System.Windows.Media.Brush>? Fill { get; set; }
		public ReactParam<global::System.String>? Indices { get; set; }
		public ReactParam<global::System.String>? UnicodeString { get; set; }
		public ReactParam<global::System.String>? CaretStops { get; set; }
		public ReactParam<global::System.Double>? FontRenderingEmSize { get; set; }
		public ReactParam<global::System.Double>? OriginX { get; set; }
		public ReactParam<global::System.Double>? OriginY { get; set; }
		public ReactParam<global::System.Uri>? FontUri { get; set; }
		public ReactParam<global::System.Windows.Media.StyleSimulations>? StyleSimulations { get; set; }
		public ReactParam<global::System.Boolean>? IsSideways { get; set; }
		public ReactParam<global::System.Int32>? BidiLevel { get; set; }
		public ReactParam<global::System.String>? DeviceFontName { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Glyphs<Glyphs>();
		}
	}
}
