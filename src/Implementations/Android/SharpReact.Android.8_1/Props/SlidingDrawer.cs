using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class SlidingDrawer: ViewGroup
	{
		public System.EventHandler DrawerClose { get; set; }
		public System.EventHandler DrawerOpen { get; set; }
		public System.EventHandler ScrollEnded { get; set; }
		public System.EventHandler ScrollStarted { get; set; }
	}
}
