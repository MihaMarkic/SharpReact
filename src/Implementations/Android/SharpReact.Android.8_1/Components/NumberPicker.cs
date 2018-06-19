using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class NumberPicker<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.NumberPicker
		where TElement : global::Android.Widget.NumberPicker
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.NumberPicker(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateNumberPickerWithInstanceProperties(Element, previous, nextProps);
			PostAssignNumberPickerProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignNumberPickerProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateNumberPickerWithInstanceProperties(element, null, props);
		}
		static void UpdateNumberPickerWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.MaxValue.HasValue)
			{
				element.MaxValue = nextProps.MaxValue.Value.Value;
			}
			if (nextProps.MinValue.HasValue)
			{
				element.MinValue = nextProps.MinValue.Value.Value;
			}
			if (nextProps.Value.HasValue)
			{
				element.Value = nextProps.Value.Value.Value;
			}
			if (nextProps.WrapSelectorWheel.HasValue)
			{
				element.WrapSelectorWheel = nextProps.WrapSelectorWheel.Value.Value;
			}
			if (!(previous?.Scroll is null) && nextProps.Scroll is null)
			{
				element.Scroll -= nextProps.Scroll;
			}
			if (previous?.Scroll is null && !(nextProps.Scroll is null))
			{
				element.Scroll += nextProps.Scroll;
			}
			if (!(previous?.ValueChanged is null) && nextProps.ValueChanged is null)
			{
				element.ValueChanged -= nextProps.ValueChanged;
			}
			if (previous?.ValueChanged is null && !(nextProps.ValueChanged is null))
			{
				element.ValueChanged += nextProps.ValueChanged;
			}
		}
	}
}
