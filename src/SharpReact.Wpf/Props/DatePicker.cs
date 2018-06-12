using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DatePicker: Control
	{
		public ReactParam<global::System.Windows.Style>? CalendarStyle { get; set; }
		public ReactParam<global::System.DateTime>? DisplayDate { get; set; }
		public ReactParam<global::System.Nullable<System.DateTime>>? DisplayDateEnd { get; set; }
		public ReactParam<global::System.Nullable<System.DateTime>>? DisplayDateStart { get; set; }
		public ReactParam<global::System.DayOfWeek>? FirstDayOfWeek { get; set; }
		public ReactParam<global::System.Boolean>? IsDropDownOpen { get; set; }
		public ReactParam<global::System.Boolean>? IsTodayHighlighted { get; set; }
		public ReactParam<global::System.Nullable<System.DateTime>>? SelectedDate { get; set; }
		public ReactParam<global::System.Windows.Controls.DatePickerFormat>? SelectedDateFormat { get; set; }
		public ReactParam<global::System.String>? Text { get; set; }
		public System.Windows.RoutedEventHandler CalendarClosed { get; set; }
		public System.Windows.RoutedEventHandler CalendarOpened { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DatePickerDateValidationErrorEventArgs> DateValidationError { get; set; }
		public System.EventHandler<global::System.Windows.Controls.SelectionChangedEventArgs> SelectedDateChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DatePicker<DatePicker, System.Windows.Controls.DatePicker>();
		}
	}
}
