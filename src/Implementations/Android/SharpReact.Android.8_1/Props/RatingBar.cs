using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class RatingBar: AbsSeekBar
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
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return IsIndicator;
				yield return NumStars;
				yield return OnRatingBarChangeListener;
				yield return Rating;
				yield return StepSize;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
