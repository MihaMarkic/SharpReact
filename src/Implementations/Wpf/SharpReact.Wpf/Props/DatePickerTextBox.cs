using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DatePickerTextBox: TextBox
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DatePickerTextBox<DatePickerTextBox>();
		}
	}
}
