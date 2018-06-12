using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class DialerFilter: RelativeLayout
	{
		public ReactParam<global::Android.Widget.DialerMode>? Mode { get; set; }
	}
}
