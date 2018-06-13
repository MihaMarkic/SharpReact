using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class RelativeLayout: ViewGroup
	{
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RelativeLayout<RelativeLayout, global::Android.Widget.RelativeLayout>();
		}
	}
}
