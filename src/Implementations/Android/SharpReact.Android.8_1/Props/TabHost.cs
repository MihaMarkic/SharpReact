using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class TabHost: FrameLayout
	{
		public ReactParam<global::System.Int32>? CurrentTab { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		public System.EventHandler<global::Android.Widget.TabHost.TabChangeEventArgs> TabChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TabHost<TabHost, global::Android.Widget.TabHost>();
		}
	}
}
