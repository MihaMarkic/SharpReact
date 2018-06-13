using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class CalendarItem: Control
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.CalendarItem<CalendarItem>();
		}
	}
}
