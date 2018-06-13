using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class AbsoluteLayout: ViewGroup
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AbsoluteLayout<AbsoluteLayout, global::Android.Widget.AbsoluteLayout>();
		}
	}
}
