using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class RadioGroup: LinearLayout
	{
		public System.EventHandler<global::Android.Widget.RadioGroup.CheckedChangeEventArgs> CheckedChange { get; set; }
	}
}
