using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class RadioButton: CompoundButton
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RadioButton<RadioButton, global::Android.Widget.RadioButton>();
		}
	}
}
