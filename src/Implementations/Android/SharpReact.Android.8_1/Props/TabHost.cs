using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class TabHost: FrameLayout
	{
		public ReactParam<global::System.Int32>? CurrentTab { get; set; }
		public System.EventHandler<global::Android.Widget.TabHost.TabChangeEventArgs> TabChanged { get; set; }
	}
}
