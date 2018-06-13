using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class AdapterViewFlipper: AdapterViewAnimator
	{
		public ReactParam<global::System.Boolean>? AutoStart { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AdapterViewFlipper<AdapterViewFlipper, global::Android.Widget.AdapterViewFlipper>();
		}
	}
}
