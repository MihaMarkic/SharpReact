using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public abstract partial class AbsSeekBar<TProps, TElement>: ProgressBar<TProps, TElement>
		where TProps : Props.AbsSeekBar
		where TElement : global::Android.Widget.AbsSeekBar
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAbsSeekBarWithInstanceProperties(Element, previous, nextProps);
			PostAssignAbsSeekBarProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAbsSeekBarProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAbsSeekBarWithInstanceProperties(element, null, props);
		}
		static void UpdateAbsSeekBarWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.KeyProgressIncrement.HasValue)
			{
				element.KeyProgressIncrement = nextProps.KeyProgressIncrement.Value.Value;
			}
			if (nextProps.SplitTrack.HasValue)
			{
				element.SplitTrack = nextProps.SplitTrack.Value.Value;
			}
			if (nextProps.ThumbOffset.HasValue)
			{
				element.ThumbOffset = nextProps.ThumbOffset.Value.Value;
			}
			if (nextProps.ThumbTintList.HasValue)
			{
				element.ThumbTintList = nextProps.ThumbTintList.Value.Value;
			}
			if (nextProps.ThumbTintMode.HasValue)
			{
				element.ThumbTintMode = nextProps.ThumbTintMode.Value.Value;
			}
			if (nextProps.TickMark.HasValue)
			{
				element.TickMark = nextProps.TickMark.Value.Value;
			}
			if (nextProps.TickMarkTintList.HasValue)
			{
				element.TickMarkTintList = nextProps.TickMarkTintList.Value.Value;
			}
			if (nextProps.TickMarkTintMode.HasValue)
			{
				element.TickMarkTintMode = nextProps.TickMarkTintMode.Value.Value;
			}
		}
	}
}
