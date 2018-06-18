using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class FragmentBreadCrumbs: ViewGroup
	{
		public System.EventHandler<global::Android.App.FragmentBreadCrumbs.BreadCrumbClickEventArgs> BreadCrumbClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FragmentBreadCrumbs<FragmentBreadCrumbs, global::Android.App.FragmentBreadCrumbs>();
		}
	}
}
