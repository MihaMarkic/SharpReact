using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class TwoLineListItem: RelativeLayout
	{
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TwoLineListItem<TwoLineListItem, global::Android.Widget.TwoLineListItem>();
		}
	}
}
