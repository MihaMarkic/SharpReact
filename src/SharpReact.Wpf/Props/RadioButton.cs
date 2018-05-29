using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class RadioButton: ToggleButton
	{
		public ReactParam<System.String>? GroupName { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RadioButton<RadioButton, System.Windows.Controls.RadioButton>();
		}
	}
}
