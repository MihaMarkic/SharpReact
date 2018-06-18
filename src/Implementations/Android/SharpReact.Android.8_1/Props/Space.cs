using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class Space: View
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Space<Space>();
		}
	}
}
