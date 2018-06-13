using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class RatingBar: AbsSeekBar
	{
		public ReactParam<global::System.Boolean>? IsIndicator { get; set; }
		public ReactParam<global::System.Int32>? NumStars { get; set; }
		public ReactParam<global::Android.Widget.RatingBar.IOnRatingBarChangeListener>? OnRatingBarChangeListener { get; set; }
		public ReactParam<global::System.Single>? Rating { get; set; }
		public ReactParam<global::System.Single>? StepSize { get; set; }
		public System.EventHandler<global::Android.Widget.RatingBar.RatingBarChangeEventArgs> RatingBarChange { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RatingBar<RatingBar, global::Android.Widget.RatingBar>();
		}
	}
}
