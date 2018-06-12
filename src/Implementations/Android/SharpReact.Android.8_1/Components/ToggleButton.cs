using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ToggleButton<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.ToggleButton
		where TElement : global::Android.Widget.ToggleButton
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.TextOffFormatted.HasValue)
			{
				Element.TextOffFormatted = nextProps.TextOffFormatted.Value.Value;
			}
			if (nextProps.TextOff.HasValue)
			{
				Element.TextOff = nextProps.TextOff.Value.Value;
			}
			if (nextProps.TextOnFormatted.HasValue)
			{
				Element.TextOnFormatted = nextProps.TextOnFormatted.Value.Value;
			}
			if (nextProps.TextOn.HasValue)
			{
				Element.TextOn = nextProps.TextOn.Value.Value;
			}
		}
	}
}
