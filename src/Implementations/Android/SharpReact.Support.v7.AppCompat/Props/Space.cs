using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class Space: View
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Space<Space, global::Android.Support.V4.Widget.Space>();
		}
	}
}
