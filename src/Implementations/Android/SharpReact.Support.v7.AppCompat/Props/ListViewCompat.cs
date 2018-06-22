using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class ListViewCompat: ListView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ListViewCompat<ListViewCompat, global::Android.Support.V7.Widget.ListViewCompat>();
		}
	}
}
