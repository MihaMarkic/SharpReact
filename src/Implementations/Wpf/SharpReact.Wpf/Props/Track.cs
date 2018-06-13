using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Track: FrameworkElement
	{
		public ReactParam<global::System.Windows.Controls.Primitives.RepeatButton>? DecreaseRepeatButton { get; set; }
		public ReactParam<global::System.Windows.Controls.Primitives.Thumb>? Thumb { get; set; }
		public ReactParam<global::System.Windows.Controls.Primitives.RepeatButton>? IncreaseRepeatButton { get; set; }
		public ReactParam<global::System.Windows.Controls.Orientation>? Orientation { get; set; }
		public ReactParam<global::System.Double>? Minimum { get; set; }
		public ReactParam<global::System.Double>? Maximum { get; set; }
		public ReactParam<global::System.Double>? Value { get; set; }
		public ReactParam<global::System.Double>? ViewportSize { get; set; }
		public ReactParam<global::System.Boolean>? IsDirectionReversed { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Track<Track, System.Windows.Controls.Primitives.Track>();
		}
	}
}
