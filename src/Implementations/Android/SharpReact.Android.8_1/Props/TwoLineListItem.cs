using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class TwoLineListItem: RelativeLayout
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TwoLineListItem<TwoLineListItem, global::Android.Widget.TwoLineListItem>();
		}
	}
}
