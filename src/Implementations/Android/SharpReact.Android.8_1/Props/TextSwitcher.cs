using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class TextSwitcher: ViewSwitcher
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TextSwitcher<TextSwitcher, global::Android.Widget.TextSwitcher>();
		}
	}
}
