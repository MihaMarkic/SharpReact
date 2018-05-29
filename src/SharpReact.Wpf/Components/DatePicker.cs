
namespace SharpReact.Wpf.Components
{
	public  class DatePicker<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.DatePicker
		where TElement : System.Windows.Controls.DatePicker
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.DatePicker();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.CalendarStyle.HasValue)
			{
				Element.CalendarStyle = nextProps.CalendarStyle.Value.Value;
			}
			if (nextProps.DisplayDate.HasValue)
			{
				Element.DisplayDate = nextProps.DisplayDate.Value.Value;
			}
			if (nextProps.DisplayDateEnd.HasValue)
			{
				Element.DisplayDateEnd = nextProps.DisplayDateEnd.Value.Value;
			}
			if (nextProps.DisplayDateStart.HasValue)
			{
				Element.DisplayDateStart = nextProps.DisplayDateStart.Value.Value;
			}
			if (nextProps.FirstDayOfWeek.HasValue)
			{
				Element.FirstDayOfWeek = nextProps.FirstDayOfWeek.Value.Value;
			}
			if (nextProps.IsDropDownOpen.HasValue)
			{
				Element.IsDropDownOpen = nextProps.IsDropDownOpen.Value.Value;
			}
			if (nextProps.IsTodayHighlighted.HasValue)
			{
				Element.IsTodayHighlighted = nextProps.IsTodayHighlighted.Value.Value;
			}
			if (nextProps.SelectedDate.HasValue)
			{
				Element.SelectedDate = nextProps.SelectedDate.Value.Value;
			}
			if (nextProps.SelectedDateFormat.HasValue)
			{
				Element.SelectedDateFormat = nextProps.SelectedDateFormat.Value.Value;
			}
			if (nextProps.Text.HasValue)
			{
				Element.Text = nextProps.Text.Value.Value;
			}
			if (!ReferenceEquals(Props?.CalendarClosed, null) && ReferenceEquals(nextProps.CalendarClosed, null))
			{
				Element.CalendarClosed -= nextProps.CalendarClosed;
			}
			if (ReferenceEquals(Props?.CalendarClosed, null) && !ReferenceEquals(nextProps.CalendarClosed, null))
			{
				Element.CalendarClosed += nextProps.CalendarClosed;
			}
			if (!ReferenceEquals(Props?.CalendarOpened, null) && ReferenceEquals(nextProps.CalendarOpened, null))
			{
				Element.CalendarOpened -= nextProps.CalendarOpened;
			}
			if (ReferenceEquals(Props?.CalendarOpened, null) && !ReferenceEquals(nextProps.CalendarOpened, null))
			{
				Element.CalendarOpened += nextProps.CalendarOpened;
			}
			if (!ReferenceEquals(Props?.DateValidationError, null) && ReferenceEquals(nextProps.DateValidationError, null))
			{
				Element.DateValidationError -= nextProps.DateValidationError;
			}
			if (ReferenceEquals(Props?.DateValidationError, null) && !ReferenceEquals(nextProps.DateValidationError, null))
			{
				Element.DateValidationError += nextProps.DateValidationError;
			}
			if (!ReferenceEquals(Props?.SelectedDateChanged, null) && ReferenceEquals(nextProps.SelectedDateChanged, null))
			{
				Element.SelectedDateChanged -= nextProps.SelectedDateChanged;
			}
			if (ReferenceEquals(Props?.SelectedDateChanged, null) && !ReferenceEquals(nextProps.SelectedDateChanged, null))
			{
				Element.SelectedDateChanged += nextProps.SelectedDateChanged;
			}
		}
	}
}
