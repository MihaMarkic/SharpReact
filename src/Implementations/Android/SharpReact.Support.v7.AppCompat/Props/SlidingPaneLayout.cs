using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class SlidingPaneLayout: ViewGroup
	{
		public ReactParam<global::System.Int32>? CoveredFadeColor { get; set; }
		public ReactParam<global::System.Int32>? ParallaxDistance { get; set; }
		public ReactParam<global::System.Int32>? SliderFadeColor { get; set; }
		public System.EventHandler<global::Android.Support.V4.Widget.SlidingPaneLayout.PanelClosedEventArgs> PanelClosed { get; set; }
		public System.EventHandler<global::Android.Support.V4.Widget.SlidingPaneLayout.PanelOpenedEventArgs> PanelOpened { get; set; }
		public System.EventHandler<global::Android.Support.V4.Widget.SlidingPaneLayout.PanelSlideEventArgs> PanelSlide { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.SlidingPaneLayout<SlidingPaneLayout, global::Android.Support.V4.Widget.SlidingPaneLayout>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return CoveredFadeColor;
				yield return ParallaxDistance;
				yield return SliderFadeColor;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
