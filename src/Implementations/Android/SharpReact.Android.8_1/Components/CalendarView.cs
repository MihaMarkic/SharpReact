using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class CalendarView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.CalendarView
		where TElement : global::Android.Widget.CalendarView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.CalendarView(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateCalendarViewWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateCalendarViewWithInstanceProperties(element, null, props);
		}
		static void UpdateCalendarViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Date.HasValue)
			{
				element.Date = nextProps.Date.Value.Value;
			}
			if (nextProps.DateTextAppearance.HasValue)
			{
				element.DateTextAppearance = nextProps.DateTextAppearance.Value.Value;
			}
			if (nextProps.FirstDayOfWeek.HasValue)
			{
				element.FirstDayOfWeek = nextProps.FirstDayOfWeek.Value.Value;
			}
			if (nextProps.MaxDate.HasValue)
			{
				element.MaxDate = nextProps.MaxDate.Value.Value;
			}
			if (nextProps.MinDate.HasValue)
			{
				element.MinDate = nextProps.MinDate.Value.Value;
			}
			if (nextProps.WeekDayTextAppearance.HasValue)
			{
				element.WeekDayTextAppearance = nextProps.WeekDayTextAppearance.Value.Value;
			}
			if (!(previous?.DateChange is null) && nextProps.DateChange is null)
			{
				element.DateChange -= nextProps.DateChange;
			}
			if (previous?.DateChange is null && !(nextProps.DateChange is null))
			{
				element.DateChange += nextProps.DateChange;
			}
		}
	}
}
