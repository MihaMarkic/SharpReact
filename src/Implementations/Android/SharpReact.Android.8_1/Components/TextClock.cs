using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class TextClock<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.TextClock
		where TElement : global::Android.Widget.TextClock
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TextClock(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateTextClockWithInstanceProperties(Element, previous, nextProps);
			PostAssignTextClockProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignTextClockProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateTextClockWithInstanceProperties(element, null, props);
		}
		static void UpdateTextClockWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Format12HourFormatted.HasValue)
			{
				element.Format12HourFormatted = nextProps.Format12HourFormatted.Value.Value;
			}
			if (nextProps.Format12Hour.HasValue)
			{
				element.Format12Hour = nextProps.Format12Hour.Value.Value;
			}
			if (nextProps.Format24HourFormatted.HasValue)
			{
				element.Format24HourFormatted = nextProps.Format24HourFormatted.Value.Value;
			}
			if (nextProps.Format24Hour.HasValue)
			{
				element.Format24Hour = nextProps.Format24Hour.Value.Value;
			}
			if (nextProps.TimeZone.HasValue)
			{
				element.TimeZone = nextProps.TimeZone.Value.Value;
			}
		}
	}
}
