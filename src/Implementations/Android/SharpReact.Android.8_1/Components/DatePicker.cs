using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class DatePicker<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.DatePicker
		where TElement : global::Android.Widget.DatePicker
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.DatePicker(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.DateTime.HasValue)
			{
				Element.DateTime = nextProps.DateTime.Value.Value;
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
			if (!ReferenceEquals(previous?.DateChanged, null) && ReferenceEquals(nextProps.DateChanged, null))
			{
				Element.DateChanged -= nextProps.DateChanged;
			}
			if (ReferenceEquals(previous?.DateChanged, null) && !ReferenceEquals(nextProps.DateChanged, null))
			{
				Element.DateChanged += nextProps.DateChanged;
			}
		}
	}
}
