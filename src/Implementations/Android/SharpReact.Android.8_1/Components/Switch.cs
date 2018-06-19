using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class Switch<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.Switch
		where TElement : global::Android.Widget.Switch
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Switch(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateSwitchWithInstanceProperties(Element, previous, nextProps);
			PostAssignSwitchProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignSwitchProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateSwitchWithInstanceProperties(element, null, props);
		}
		static void UpdateSwitchWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.ShowText.HasValue)
			{
				element.ShowText = nextProps.ShowText.Value.Value;
			}
			if (nextProps.SplitTrack.HasValue)
			{
				element.SplitTrack = nextProps.SplitTrack.Value.Value;
			}
			if (nextProps.SwitchMinWidth.HasValue)
			{
				element.SwitchMinWidth = nextProps.SwitchMinWidth.Value.Value;
			}
			if (nextProps.SwitchPadding.HasValue)
			{
				element.SwitchPadding = nextProps.SwitchPadding.Value.Value;
			}
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
			if (nextProps.ThumbDrawable.HasValue)
			{
				element.ThumbDrawable = nextProps.ThumbDrawable.Value.Value;
			}
			if (nextProps.ThumbTextPadding.HasValue)
			{
				element.ThumbTextPadding = nextProps.ThumbTextPadding.Value.Value;
			}
			if (nextProps.ThumbTintList.HasValue)
			{
				element.ThumbTintList = nextProps.ThumbTintList.Value.Value;
			}
			if (nextProps.ThumbTintMode.HasValue)
			{
				element.ThumbTintMode = nextProps.ThumbTintMode.Value.Value;
			}
			if (nextProps.TrackDrawable.HasValue)
			{
				element.TrackDrawable = nextProps.TrackDrawable.Value.Value;
			}
			if (nextProps.TrackTintList.HasValue)
			{
				element.TrackTintList = nextProps.TrackTintList.Value.Value;
			}
			if (nextProps.TrackTintMode.HasValue)
			{
				element.TrackTintMode = nextProps.TrackTintMode.Value.Value;
			}
		}
	}
}
