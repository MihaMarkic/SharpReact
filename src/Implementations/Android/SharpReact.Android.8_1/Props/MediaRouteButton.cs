using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class MediaRouteButton: View
	{
		public ReactParam<global::Android.Media.MediaRouteType>? RouteTypes { get; set; }
		public System.EventHandler ExtendedSettingsClick { get; set; }
	}
}
