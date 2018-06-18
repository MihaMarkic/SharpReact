using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class TabWidget: LinearLayout
	{
		public ReactParam<global::System.Boolean>? StripEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TabWidget<TabWidget, global::Android.Widget.TabWidget>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return StripEnabled;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
