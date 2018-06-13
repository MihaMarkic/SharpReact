using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class ZoomButton: ImageButton
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ZoomButton<ZoomButton, global::Android.Widget.ZoomButton>();
		}
	}
}
