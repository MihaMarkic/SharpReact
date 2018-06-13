using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class TabWidget: LinearLayout
	{
		public ReactParam<global::System.Boolean>? StripEnabled { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TabWidget<TabWidget, global::Android.Widget.TabWidget>();
		}
	}
}
