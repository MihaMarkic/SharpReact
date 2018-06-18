using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class SurfaceView: View
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.SurfaceView<SurfaceView, global::Android.Views.SurfaceView>();
		}
	}
}
