using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class ViewPager: ViewGroup
	{
		public ReactParam<global::Android.Support.V4.View.PagerAdapter>? Adapter { get; set; }
		public ReactParam<global::System.Int32>? CurrentItem { get; set; }
		public ReactParam<global::System.Int32>? OffscreenPageLimit { get; set; }
		public ReactParam<global::System.Int32>? PageMargin { get; set; }
		public System.EventHandler<global::Android.Support.V4.View.ViewPager.AdapterChangeEventArgs> AdapterChange { get; set; }
		public System.EventHandler<global::Android.Support.V4.View.ViewPager.PageScrollStateChangedEventArgs> PageScrollStateChanged { get; set; }
		public System.EventHandler<global::Android.Support.V4.View.ViewPager.PageScrolledEventArgs> PageScrolled { get; set; }
		public System.EventHandler<global::Android.Support.V4.View.ViewPager.PageSelectedEventArgs> PageSelected { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ViewPager<ViewPager, global::Android.Support.V4.View.ViewPager>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Adapter;
				yield return CurrentItem;
				yield return OffscreenPageLimit;
				yield return PageMargin;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
