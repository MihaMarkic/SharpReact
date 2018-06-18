using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class DialerFilter: RelativeLayout
	{
		public ReactParam<global::Android.Widget.DialerMode>? Mode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DialerFilter<DialerFilter, global::Android.Widget.DialerFilter>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Mode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
