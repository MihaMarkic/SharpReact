using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class HorizontalScrollView: FrameLayout
	{
		public ReactParam<global::System.Boolean>? FillViewport { get; set; }
		public ReactParam<global::System.Boolean>? SmoothScrollingEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.HorizontalScrollView<HorizontalScrollView, global::Android.Widget.HorizontalScrollView>();
		}
	}
}
