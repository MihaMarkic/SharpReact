using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ImageView: View
	{
		public ReactParam<global::System.Boolean>? BaselineAlignBottom { get; set; }
		public ReactParam<global::System.Boolean>? CropToPadding { get; set; }
		public ReactParam<global::System.Int32>? ImageAlpha { get; set; }
		public ReactParam<global::Android.Graphics.Matrix>? ImageMatrix { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? ImageTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ImageTintMode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ImageView<ImageView, global::Android.Widget.ImageView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return BaselineAlignBottom;
				yield return CropToPadding;
				yield return ImageAlpha;
				yield return ImageMatrix;
				yield return ImageTintList;
				yield return ImageTintMode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
