using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class FrameLayout: ViewGroup
	{
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? Foreground { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? ForegroundTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ForegroundTintMode { get; set; }
		public ReactParam<global::System.Boolean>? MeasureAllChildren { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FrameLayout<FrameLayout, global::Android.Widget.FrameLayout>();
		}
	}
}
