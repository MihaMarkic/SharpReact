using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class SwipeRefreshLayout: ViewGroup
	{
		public ReactParam<global::System.Boolean>? NestedScrollingEnabled { get; set; }
		public ReactParam<global::System.Boolean>? Refreshing { get; set; }
		public System.EventHandler Refresh { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.SwipeRefreshLayout<SwipeRefreshLayout, global::Android.Support.V4.Widget.SwipeRefreshLayout>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return NestedScrollingEnabled;
				yield return Refreshing;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
