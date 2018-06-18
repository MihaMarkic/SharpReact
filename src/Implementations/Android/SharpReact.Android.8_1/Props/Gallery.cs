using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class Gallery: AbsSpinner
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Gallery<Gallery, global::Android.Widget.Gallery>();
		}
	}
}
