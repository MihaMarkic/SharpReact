using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class TabWidget: LinearLayout
	{
		public ReactParam<global::System.Boolean>? StripEnabled { get; set; }
	}
}
