using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ProgressBar: View
	{
		public ReactParam<global::System.Boolean>? Indeterminate { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? IndeterminateDrawable { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? IndeterminateTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? IndeterminateTintMode { get; set; }
		public ReactParam<global::Android.Views.Animations.IInterpolator>? Interpolator { get; set; }
		public ReactParam<global::System.Int32>? Max { get; set; }
		public ReactParam<global::System.Int32>? Min { get; set; }
		public ReactParam<global::System.Int32>? Progress { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? ProgressBackgroundTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ProgressBackgroundTintMode { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? ProgressDrawable { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? ProgressTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ProgressTintMode { get; set; }
		public ReactParam<global::System.Int32>? SecondaryProgress { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? SecondaryProgressTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? SecondaryProgressTintMode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ProgressBar<ProgressBar, global::Android.Widget.ProgressBar>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Indeterminate;
				yield return IndeterminateDrawable;
				yield return IndeterminateTintList;
				yield return IndeterminateTintMode;
				yield return Interpolator;
				yield return Max;
				yield return Min;
				yield return Progress;
				yield return ProgressBackgroundTintList;
				yield return ProgressBackgroundTintMode;
				yield return ProgressDrawable;
				yield return ProgressTintList;
				yield return ProgressTintMode;
				yield return SecondaryProgress;
				yield return SecondaryProgressTintList;
				yield return SecondaryProgressTintMode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
