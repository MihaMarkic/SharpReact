using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class MediaRouteButton: View
	{
		public ReactParam<global::Android.Media.MediaRouteType>? RouteTypes { get; set; }
		public System.EventHandler ExtendedSettingsClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.MediaRouteButton<MediaRouteButton, global::Android.App.MediaRouteButton>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return RouteTypes;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
