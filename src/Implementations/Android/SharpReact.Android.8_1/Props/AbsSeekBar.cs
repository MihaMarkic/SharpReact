using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract partial class AbsSeekBar: ProgressBar
	{
		public ReactParam<global::System.Int32>? KeyProgressIncrement { get; set; }
		public ReactParam<global::System.Boolean>? SplitTrack { get; set; }
		public ReactParam<global::System.Int32>? ThumbOffset { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? ThumbTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ThumbTintMode { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? TickMark { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? TickMarkTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? TickMarkTintMode { get; set; }
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return KeyProgressIncrement;
				yield return SplitTrack;
				yield return ThumbOffset;
				yield return ThumbTintList;
				yield return ThumbTintMode;
				yield return TickMark;
				yield return TickMarkTintList;
				yield return TickMarkTintMode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
