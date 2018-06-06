using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Calendar<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.Calendar
		where TElement : System.Windows.Controls.Calendar, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.CalendarButtonStyle.HasValue)
			{
				Element.CalendarButtonStyle = nextProps.CalendarButtonStyle.Value.Value;
			}
			if (nextProps.CalendarDayButtonStyle.HasValue)
			{
				Element.CalendarDayButtonStyle = nextProps.CalendarDayButtonStyle.Value.Value;
			}
			if (nextProps.CalendarItemStyle.HasValue)
			{
				Element.CalendarItemStyle = nextProps.CalendarItemStyle.Value.Value;
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
			if (nextProps.DisplayMode.HasValue)
			{
				Element.DisplayMode = nextProps.DisplayMode.Value.Value;
			}
			if (nextProps.FirstDayOfWeek.HasValue)
			{
				Element.FirstDayOfWeek = nextProps.FirstDayOfWeek.Value.Value;
			}
			if (nextProps.IsTodayHighlighted.HasValue)
			{
				Element.IsTodayHighlighted = nextProps.IsTodayHighlighted.Value.Value;
			}
			if (nextProps.SelectedDate.HasValue)
			{
				Element.SelectedDate = nextProps.SelectedDate.Value.Value;
			}
			if (nextProps.SelectionMode.HasValue)
			{
				Element.SelectionMode = nextProps.SelectionMode.Value.Value;
			}
			if (!ReferenceEquals(Props?.SelectedDatesChanged, null) && ReferenceEquals(nextProps.SelectedDatesChanged, null))
			{
				Element.SelectedDatesChanged -= nextProps.SelectedDatesChanged;
			}
			if (ReferenceEquals(Props?.SelectedDatesChanged, null) && !ReferenceEquals(nextProps.SelectedDatesChanged, null))
			{
				Element.SelectedDatesChanged += nextProps.SelectedDatesChanged;
			}
			if (!ReferenceEquals(Props?.DisplayDateChanged, null) && ReferenceEquals(nextProps.DisplayDateChanged, null))
			{
				Element.DisplayDateChanged -= nextProps.DisplayDateChanged;
			}
			if (ReferenceEquals(Props?.DisplayDateChanged, null) && !ReferenceEquals(nextProps.DisplayDateChanged, null))
			{
				Element.DisplayDateChanged += nextProps.DisplayDateChanged;
			}
			if (!ReferenceEquals(Props?.DisplayModeChanged, null) && ReferenceEquals(nextProps.DisplayModeChanged, null))
			{
				Element.DisplayModeChanged -= nextProps.DisplayModeChanged;
			}
			if (ReferenceEquals(Props?.DisplayModeChanged, null) && !ReferenceEquals(nextProps.DisplayModeChanged, null))
			{
				Element.DisplayModeChanged += nextProps.DisplayModeChanged;
			}
			if (!ReferenceEquals(Props?.SelectionModeChanged, null) && ReferenceEquals(nextProps.SelectionModeChanged, null))
			{
				Element.SelectionModeChanged -= nextProps.SelectionModeChanged;
			}
			if (ReferenceEquals(Props?.SelectionModeChanged, null) && !ReferenceEquals(nextProps.SelectionModeChanged, null))
			{
				Element.SelectionModeChanged += nextProps.SelectionModeChanged;
			}
		}
	}
}
