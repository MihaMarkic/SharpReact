using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class RSSurfaceView: SurfaceView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RSSurfaceView<RSSurfaceView, global::Android.Renderscripts.RSSurfaceView>();
		}
	}
}
