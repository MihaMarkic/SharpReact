using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class ViewSwitcher: ViewAnimator
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ViewSwitcher<ViewSwitcher, global::Android.Widget.ViewSwitcher>();
		}
	}
}
