using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class ZoomControls: LinearLayout
	{
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		public System.EventHandler ZoomInClick { get; set; }
		public System.EventHandler ZoomOutClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ZoomControls<ZoomControls, global::Android.Widget.ZoomControls>();
		}
	}
}
