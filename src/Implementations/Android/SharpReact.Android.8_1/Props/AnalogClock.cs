using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class AnalogClock: View
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AnalogClock<AnalogClock, global::Android.Widget.AnalogClock>();
		}
	}
}
