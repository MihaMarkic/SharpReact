using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class ZoomControls: LinearLayout
	{
		public System.EventHandler ZoomInClick { get; set; }
		public System.EventHandler ZoomOutClick { get; set; }
	}
}
