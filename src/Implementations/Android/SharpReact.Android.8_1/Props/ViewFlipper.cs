using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class ViewFlipper: ViewAnimator
	{
		public ReactParam<global::System.Boolean>? AutoStart { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ViewFlipper<ViewFlipper, global::Android.Widget.ViewFlipper>();
		}
	}
}
