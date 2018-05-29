using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class CalendarDayButton: Button
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.CalendarDayButton<CalendarDayButton>();
		}
	}
}
