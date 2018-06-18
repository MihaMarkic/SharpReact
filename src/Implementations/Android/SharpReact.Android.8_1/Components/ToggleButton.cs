using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ToggleButton<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.ToggleButton
		where TElement : global::Android.Widget.ToggleButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ToggleButton(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateToggleButtonWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateToggleButtonWithInstanceProperties(element, null, props);
		}
		static void UpdateToggleButtonWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.TextOffFormatted.HasValue)
			{
				element.TextOffFormatted = nextProps.TextOffFormatted.Value.Value;
			}
			if (nextProps.TextOff.HasValue)
			{
				element.TextOff = nextProps.TextOff.Value.Value;
			}
			if (nextProps.TextOnFormatted.HasValue)
			{
				element.TextOnFormatted = nextProps.TextOnFormatted.Value.Value;
			}
			if (nextProps.TextOn.HasValue)
			{
				element.TextOn = nextProps.TextOn.Value.Value;
			}
		}
	}
}
