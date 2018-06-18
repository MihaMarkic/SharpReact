using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class DigitalClock: TextView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DigitalClock<DigitalClock, global::Android.Widget.DigitalClock>();
		}
	}
}
