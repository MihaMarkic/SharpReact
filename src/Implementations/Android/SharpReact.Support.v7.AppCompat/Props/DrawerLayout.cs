using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class DrawerLayout: ViewGroup
	{
		public ReactParam<global::System.Single>? DrawerElevation { get; set; }
		public System.EventHandler<global::Android.Support.V4.Widget.DrawerLayout.DrawerClosedEventArgs> DrawerClosed { get; set; }
		public System.EventHandler<global::Android.Support.V4.Widget.DrawerLayout.DrawerOpenedEventArgs> DrawerOpened { get; set; }
		public System.EventHandler<global::Android.Support.V4.Widget.DrawerLayout.DrawerSlideEventArgs> DrawerSlide { get; set; }
		public System.EventHandler<global::Android.Support.V4.Widget.DrawerLayout.DrawerStateChangedEventArgs> DrawerStateChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DrawerLayout<DrawerLayout, global::Android.Support.V4.Widget.DrawerLayout>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return DrawerElevation;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
