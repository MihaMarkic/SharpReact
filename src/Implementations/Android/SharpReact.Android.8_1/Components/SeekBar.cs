using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class SeekBar<TProps, TElement>: AbsSeekBar<TProps, TElement>
		where TProps : Props.SeekBar
		where TElement : global::Android.Widget.SeekBar
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.SeekBar(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(previous?.ProgressChanged, null) && ReferenceEquals(nextProps.ProgressChanged, null))
			{
				Element.ProgressChanged -= nextProps.ProgressChanged;
			}
			if (ReferenceEquals(previous?.ProgressChanged, null) && !ReferenceEquals(nextProps.ProgressChanged, null))
			{
				Element.ProgressChanged += nextProps.ProgressChanged;
			}
			if (!ReferenceEquals(previous?.StartTrackingTouch, null) && ReferenceEquals(nextProps.StartTrackingTouch, null))
			{
				Element.StartTrackingTouch -= nextProps.StartTrackingTouch;
			}
			if (ReferenceEquals(previous?.StartTrackingTouch, null) && !ReferenceEquals(nextProps.StartTrackingTouch, null))
			{
				Element.StartTrackingTouch += nextProps.StartTrackingTouch;
			}
			if (!ReferenceEquals(previous?.StopTrackingTouch, null) && ReferenceEquals(nextProps.StopTrackingTouch, null))
			{
				Element.StopTrackingTouch -= nextProps.StopTrackingTouch;
			}
			if (ReferenceEquals(previous?.StopTrackingTouch, null) && !ReferenceEquals(nextProps.StopTrackingTouch, null))
			{
				Element.StopTrackingTouch += nextProps.StopTrackingTouch;
			}
		}
	}
}
