using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class MediaRouteButton: View
	{
		public ReactParam<global::Android.Media.MediaRouteType>? RouteTypes { get; set; }
		public System.EventHandler ExtendedSettingsClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.MediaRouteButton<MediaRouteButton, global::Android.App.MediaRouteButton>();
		}
	}
}
