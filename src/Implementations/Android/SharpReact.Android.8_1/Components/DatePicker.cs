using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class DatePicker<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.DatePicker
		where TElement : global::Android.Widget.DatePicker
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.DatePicker(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateDatePickerWithInstanceProperties(Element, previous, nextProps);
			PostAssignDatePickerProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignDatePickerProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateDatePickerWithInstanceProperties(element, null, props);
		}
		static void UpdateDatePickerWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.DateTime.HasValue)
			{
				element.DateTime = nextProps.DateTime.Value.Value;
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
			if (!(previous?.DateChanged is null) && nextProps.DateChanged is null)
			{
				element.DateChanged -= nextProps.DateChanged;
			}
			if (previous?.DateChanged is null && !(nextProps.DateChanged is null))
			{
				element.DateChanged += nextProps.DateChanged;
			}
		}
	}
}
