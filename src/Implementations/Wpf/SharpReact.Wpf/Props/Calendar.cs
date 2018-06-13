using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Calendar: Control
	{
		public ReactParam<global::System.Windows.Style>? CalendarButtonStyle { get; set; }
		public ReactParam<global::System.Windows.Style>? CalendarDayButtonStyle { get; set; }
		public ReactParam<global::System.Windows.Style>? CalendarItemStyle { get; set; }
		public ReactParam<global::System.DateTime>? DisplayDate { get; set; }
		public ReactParam<global::System.Nullable<System.DateTime>>? DisplayDateEnd { get; set; }
		public ReactParam<global::System.Nullable<System.DateTime>>? DisplayDateStart { get; set; }
		public ReactParam<global::System.Windows.Controls.CalendarMode>? DisplayMode { get; set; }
		public ReactParam<global::System.DayOfWeek>? FirstDayOfWeek { get; set; }
		public ReactParam<global::System.Boolean>? IsTodayHighlighted { get; set; }
		public ReactParam<global::System.Nullable<System.DateTime>>? SelectedDate { get; set; }
		public ReactParam<global::System.Windows.Controls.CalendarSelectionMode>? SelectionMode { get; set; }
		public System.EventHandler<global::System.Windows.Controls.SelectionChangedEventArgs> SelectedDatesChanged { get; set; }
		public System.EventHandler<global::System.Windows.Controls.CalendarDateChangedEventArgs> DisplayDateChanged { get; set; }
		public System.EventHandler<global::System.Windows.Controls.CalendarModeChangedEventArgs> DisplayModeChanged { get; set; }
		public System.EventHandler<global::System.EventArgs> SelectionModeChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Calendar<Calendar, System.Windows.Controls.Calendar>();
		}
	}
}
