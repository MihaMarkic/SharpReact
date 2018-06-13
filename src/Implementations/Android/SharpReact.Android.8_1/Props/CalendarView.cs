using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class CalendarView: FrameLayout
	{
		public ReactParam<global::System.Int64>? Date { get; set; }
		public ReactParam<global::System.Int32>? DateTextAppearance { get; set; }
		public ReactParam<global::System.Int32>? FirstDayOfWeek { get; set; }
		public ReactParam<global::System.Int64>? MaxDate { get; set; }
		public ReactParam<global::System.Int64>? MinDate { get; set; }
		public ReactParam<global::System.Int32>? WeekDayTextAppearance { get; set; }
		public System.EventHandler<global::Android.Widget.CalendarView.DateChangeEventArgs> DateChange { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.CalendarView<CalendarView, global::Android.Widget.CalendarView>();
		}
	}
}
