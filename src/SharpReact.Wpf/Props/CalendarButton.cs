using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class CalendarButton: Button
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.CalendarButton<CalendarButton>();
		}
	}
}
