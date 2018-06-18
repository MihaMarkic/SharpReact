using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ScrollView: FrameLayout
	{
		public ReactParam<global::System.Boolean>? FillViewport { get; set; }
		public ReactParam<global::System.Boolean>? SmoothScrollingEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ScrollView<ScrollView, global::Android.Widget.ScrollView>();
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
