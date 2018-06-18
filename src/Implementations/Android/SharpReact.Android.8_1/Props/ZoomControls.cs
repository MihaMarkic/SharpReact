using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ZoomControls: LinearLayout
	{
		public System.EventHandler ZoomInClick { get; set; }
		public System.EventHandler ZoomOutClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ZoomControls<ZoomControls, global::Android.Widget.ZoomControls>();
		}
	}
}
