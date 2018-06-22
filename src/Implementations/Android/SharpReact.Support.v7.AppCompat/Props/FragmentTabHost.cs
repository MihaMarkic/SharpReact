using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class FragmentTabHost: TabHost
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FragmentTabHost<FragmentTabHost, global::Android.Support.V4.App.FragmentTabHost>();
		}
	}
}
