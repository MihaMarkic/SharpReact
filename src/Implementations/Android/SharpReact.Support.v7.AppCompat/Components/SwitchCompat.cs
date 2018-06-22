using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class SwitchCompat<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.SwitchCompat
		where TElement : global::Android.Support.V7.Widget.SwitchCompat
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.SwitchCompat(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateSwitchCompatWithInstanceProperties(Element, previous, nextProps);
			PostAssignSwitchCompatProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignSwitchCompatProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateSwitchCompatWithInstanceProperties(element, null, props);
		}
		static void UpdateSwitchCompatWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
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
