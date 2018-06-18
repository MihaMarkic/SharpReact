using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class NumberPicker<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.NumberPicker
		where TElement : global::Android.Widget.NumberPicker
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.NumberPicker(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateNumberPickerWithInstanceProperties(Element, previous, nextProps);
		}
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
