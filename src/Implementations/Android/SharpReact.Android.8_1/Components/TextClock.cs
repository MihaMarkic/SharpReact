using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class TextClock<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.TextClock
		where TElement : global::Android.Widget.TextClock
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Format12HourFormatted.HasValue)
			{
				Element.Format12HourFormatted = nextProps.Format12HourFormatted.Value.Value;
			}
			if (nextProps.Format12Hour.HasValue)
			{
				Element.Format12Hour = nextProps.Format12Hour.Value.Value;
			}
			if (nextProps.Format24HourFormatted.HasValue)
			{
				Element.Format24HourFormatted = nextProps.Format24HourFormatted.Value.Value;
			}
			if (nextProps.Format24Hour.HasValue)
			{
				Element.Format24Hour = nextProps.Format24Hour.Value.Value;
			}
			if (nextProps.TimeZone.HasValue)
			{
				Element.TimeZone = nextProps.TimeZone.Value.Value;
			}
		}
	}
}
