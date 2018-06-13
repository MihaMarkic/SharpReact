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
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Date.HasValue)
			{
				Element.Date = nextProps.Date.Value.Value;
			}
			if (nextProps.DateTextAppearance.HasValue)
			{
				Element.DateTextAppearance = nextProps.DateTextAppearance.Value.Value;
			}
			if (nextProps.FirstDayOfWeek.HasValue)
			{
				Element.FirstDayOfWeek = nextProps.FirstDayOfWeek.Value.Value;
			}
			if (nextProps.MaxDate.HasValue)
			{
				Element.MaxDate = nextProps.MaxDate.Value.Value;
			}
			if (nextProps.MinDate.HasValue)
			{
				Element.MinDate = nextProps.MinDate.Value.Value;
			}
			if (nextProps.WeekDayTextAppearance.HasValue)
			{
				Element.WeekDayTextAppearance = nextProps.WeekDayTextAppearance.Value.Value;
			}
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.CalendarView.Views), nameof(SharpReact.Android.Props.CalendarView));
				ElementSynchronizer.SyncElements(Element, elements);
			}
			if (!ReferenceEquals(previous?.DateChange, null) && ReferenceEquals(nextProps.DateChange, null))
			{
				Element.DateChange -= nextProps.DateChange;
			}
			if (ReferenceEquals(previous?.DateChange, null) && !ReferenceEquals(nextProps.DateChange, null))
			{
				Element.DateChange += nextProps.DateChange;
			}
		}
	}
}
