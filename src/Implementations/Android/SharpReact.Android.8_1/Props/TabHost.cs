using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class TabHost: FrameLayout
	{
		public ReactParam<global::System.Int32>? CurrentTab { get; set; }
		public System.EventHandler<global::Android.Widget.TabHost.TabChangeEventArgs> TabChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TabHost<TabHost, global::Android.Widget.TabHost>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return CurrentTab;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
