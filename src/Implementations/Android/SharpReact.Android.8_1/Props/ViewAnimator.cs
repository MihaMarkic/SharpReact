using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class ViewAnimator: FrameLayout
	{
		public ReactParam<global::System.Int32>? DisplayedChild { get; set; }
		public ReactParam<global::Android.Views.Animations.Animation>? InAnimation { get; set; }
		public ReactParam<global::Android.Views.Animations.Animation>? OutAnimation { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ViewAnimator<ViewAnimator, global::Android.Widget.ViewAnimator>();
		}
	}
}
