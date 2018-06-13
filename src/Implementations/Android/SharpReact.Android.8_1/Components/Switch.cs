using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class Switch<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.Switch
		where TElement : global::Android.Widget.Switch
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Switch(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ShowText.HasValue)
			{
				Element.ShowText = nextProps.ShowText.Value.Value;
			}
			if (nextProps.SplitTrack.HasValue)
			{
				Element.SplitTrack = nextProps.SplitTrack.Value.Value;
			}
			if (nextProps.SwitchMinWidth.HasValue)
			{
				Element.SwitchMinWidth = nextProps.SwitchMinWidth.Value.Value;
			}
			if (nextProps.SwitchPadding.HasValue)
			{
				Element.SwitchPadding = nextProps.SwitchPadding.Value.Value;
			}
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
			if (nextProps.ThumbDrawable.HasValue)
			{
				Element.ThumbDrawable = nextProps.ThumbDrawable.Value.Value;
			}
			if (nextProps.ThumbTextPadding.HasValue)
			{
				Element.ThumbTextPadding = nextProps.ThumbTextPadding.Value.Value;
			}
			if (nextProps.ThumbTintList.HasValue)
			{
				Element.ThumbTintList = nextProps.ThumbTintList.Value.Value;
			}
			if (nextProps.ThumbTintMode.HasValue)
			{
				Element.ThumbTintMode = nextProps.ThumbTintMode.Value.Value;
			}
			if (nextProps.TrackDrawable.HasValue)
			{
				Element.TrackDrawable = nextProps.TrackDrawable.Value.Value;
			}
			if (nextProps.TrackTintList.HasValue)
			{
				Element.TrackTintList = nextProps.TrackTintList.Value.Value;
			}
			if (nextProps.TrackTintMode.HasValue)
			{
				Element.TrackTintMode = nextProps.TrackTintMode.Value.Value;
			}
		}
	}
}
