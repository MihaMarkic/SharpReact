using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class RadioGroup: LinearLayout
	{
		public System.EventHandler<global::Android.Widget.RadioGroup.CheckedChangeEventArgs> CheckedChange { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RadioGroup<RadioGroup, global::Android.Widget.RadioGroup>();
		}
	}
}
