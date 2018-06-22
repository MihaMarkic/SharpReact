using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class NestedScrollView: FrameLayout
	{
		public ReactParam<global::System.Boolean>? FillViewport { get; set; }
		public ReactParam<global::System.Boolean>? SmoothScrollingEnabled { get; set; }
		public System.EventHandler<global::Android.Support.V4.Widget.NestedScrollView.ScrollChangeEventArgs> ScrollChange { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.NestedScrollView<NestedScrollView, global::Android.Support.V4.Widget.NestedScrollView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return FillViewport;
				yield return SmoothScrollingEnabled;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
