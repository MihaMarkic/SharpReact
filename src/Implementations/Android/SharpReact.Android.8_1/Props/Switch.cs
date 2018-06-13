using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class Switch: CompoundButton
	{
		public ReactParam<global::System.Boolean>? ShowText { get; set; }
		public ReactParam<global::System.Boolean>? SplitTrack { get; set; }
		public ReactParam<global::System.Int32>? SwitchMinWidth { get; set; }
		public ReactParam<global::System.Int32>? SwitchPadding { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? TextOffFormatted { get; set; }
		public ReactParam<global::System.String>? TextOff { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? TextOnFormatted { get; set; }
		public ReactParam<global::System.String>? TextOn { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? ThumbDrawable { get; set; }
		public ReactParam<global::System.Int32>? ThumbTextPadding { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? ThumbTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ThumbTintMode { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? TrackDrawable { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? TrackTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? TrackTintMode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Switch<Switch, global::Android.Widget.Switch>();
		}
	}
}
