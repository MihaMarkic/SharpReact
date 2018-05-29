using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class CheckBox: ToggleButton
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.CheckBox<CheckBox, System.Windows.Controls.CheckBox>();
		}
	}
}
