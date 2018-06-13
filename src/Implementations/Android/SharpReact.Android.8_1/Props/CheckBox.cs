using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class CheckBox: CompoundButton
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.CheckBox<CheckBox, global::Android.Widget.CheckBox>();
		}
	}
}
