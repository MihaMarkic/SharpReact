using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class RelativeLayout: ViewGroup
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RelativeLayout<RelativeLayout, global::Android.Widget.RelativeLayout>();
		}
	}
}
