using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class FragmentBreadCrumbs: ViewGroup
	{
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		public System.EventHandler<global::Android.App.FragmentBreadCrumbs.BreadCrumbClickEventArgs> BreadCrumbClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FragmentBreadCrumbs<FragmentBreadCrumbs, global::Android.App.FragmentBreadCrumbs>();
		}
	}
}
