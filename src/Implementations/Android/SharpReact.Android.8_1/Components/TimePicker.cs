using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class TimePicker<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.TimePicker
		where TElement : global::Android.Widget.TimePicker
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TimePicker(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateTimePickerWithInstanceProperties(Element, previous, nextProps);
			PostAssignTimePickerProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignTimePickerProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateTimePickerWithInstanceProperties(element, null, props);
		}
		static void UpdateTimePickerWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Hour.HasValue)
			{
				element.Hour = nextProps.Hour.Value.Value;
			}
			if (nextProps.Minute.HasValue)
			{
				element.Minute = nextProps.Minute.Value.Value;
			}
			if (!(previous?.TimeChanged is null) && nextProps.TimeChanged is null)
			{
				element.TimeChanged -= nextProps.TimeChanged;
			}
			if (previous?.TimeChanged is null && !(nextProps.TimeChanged is null))
			{
				element.TimeChanged += nextProps.TimeChanged;
			}
		}
	}
}
