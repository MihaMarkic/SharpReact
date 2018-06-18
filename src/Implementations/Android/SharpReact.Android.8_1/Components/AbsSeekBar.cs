using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class AbsSeekBar<TProps, TElement>: ProgressBar<TProps, TElement>
		where TProps : Props.AbsSeekBar
		where TElement : global::Android.Widget.AbsSeekBar
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.KeyProgressIncrement.HasValue)
			{
				Element.KeyProgressIncrement = nextProps.KeyProgressIncrement.Value.Value;
			}
			if (nextProps.SplitTrack.HasValue)
			{
				Element.SplitTrack = nextProps.SplitTrack.Value.Value;
			}
			if (nextProps.ThumbOffset.HasValue)
			{
				Element.ThumbOffset = nextProps.ThumbOffset.Value.Value;
			}
			if (nextProps.ThumbTintList.HasValue)
			{
				Element.ThumbTintList = nextProps.ThumbTintList.Value.Value;
			}
			if (nextProps.ThumbTintMode.HasValue)
			{
				Element.ThumbTintMode = nextProps.ThumbTintMode.Value.Value;
			}
			if (nextProps.TickMark.HasValue)
			{
				Element.TickMark = nextProps.TickMark.Value.Value;
			}
			if (nextProps.TickMarkTintList.HasValue)
			{
				Element.TickMarkTintList = nextProps.TickMarkTintList.Value.Value;
			}
			if (nextProps.TickMarkTintMode.HasValue)
			{
				Element.TickMarkTintMode = nextProps.TickMarkTintMode.Value.Value;
			}
		}
	}
}
