using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class DialerFilter: RelativeLayout
	{
		public ReactParam<global::Android.Widget.DialerMode>? Mode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DialerFilter<DialerFilter, global::Android.Widget.DialerFilter>();
		}
	}
}
