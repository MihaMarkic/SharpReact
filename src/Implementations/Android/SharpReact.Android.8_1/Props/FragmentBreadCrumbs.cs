using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class FragmentBreadCrumbs: ViewGroup
	{
		public System.EventHandler<global::Android.App.FragmentBreadCrumbs.BreadCrumbClickEventArgs> BreadCrumbClick { get; set; }
	}
}
