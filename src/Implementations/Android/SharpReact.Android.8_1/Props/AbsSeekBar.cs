using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class AbsSeekBar: ProgressBar
	{
		public ReactParam<global::System.Int32>? KeyProgressIncrement { get; set; }
		public ReactParam<global::System.Boolean>? SplitTrack { get; set; }
		public ReactParam<global::System.Int32>? ThumbOffset { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? ThumbTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ThumbTintMode { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? TickMark { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? TickMarkTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? TickMarkTintMode { get; set; }
	}
}
