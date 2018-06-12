using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class ImageView: View
	{
		public ReactParam<global::System.Boolean>? BaselineAlignBottom { get; set; }
		public ReactParam<global::System.Boolean>? CropToPadding { get; set; }
		public ReactParam<global::System.Int32>? ImageAlpha { get; set; }
		public ReactParam<global::Android.Graphics.Matrix>? ImageMatrix { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? ImageTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ImageTintMode { get; set; }
	}
}
