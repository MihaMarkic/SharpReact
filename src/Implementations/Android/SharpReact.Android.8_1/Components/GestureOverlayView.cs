using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class GestureOverlayView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.GestureOverlayView
		where TElement : global::Android.Gestures.GestureOverlayView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.EventsInterceptionEnabled.HasValue)
			{
				Element.EventsInterceptionEnabled = nextProps.EventsInterceptionEnabled.Value.Value;
			}
			if (nextProps.FadeEnabled.HasValue)
			{
				Element.FadeEnabled = nextProps.FadeEnabled.Value.Value;
			}
			if (nextProps.FadeOffset.HasValue)
			{
				Element.FadeOffset = nextProps.FadeOffset.Value.Value;
			}
			if (nextProps.Gesture.HasValue)
			{
				Element.Gesture = nextProps.Gesture.Value.Value;
			}
			if (nextProps.GestureColor.HasValue)
			{
				Element.GestureColor = nextProps.GestureColor.Value.Value;
			}
			if (nextProps.GestureStrokeAngleThreshold.HasValue)
			{
				Element.GestureStrokeAngleThreshold = nextProps.GestureStrokeAngleThreshold.Value.Value;
			}
			if (nextProps.GestureStrokeLengthThreshold.HasValue)
			{
				Element.GestureStrokeLengthThreshold = nextProps.GestureStrokeLengthThreshold.Value.Value;
			}
			if (nextProps.GestureStrokeSquarenessTreshold.HasValue)
			{
				Element.GestureStrokeSquarenessTreshold = nextProps.GestureStrokeSquarenessTreshold.Value.Value;
			}
			if (nextProps.GestureStrokeType.HasValue)
			{
				Element.GestureStrokeType = nextProps.GestureStrokeType.Value.Value;
			}
			if (nextProps.GestureStrokeWidth.HasValue)
			{
				Element.GestureStrokeWidth = nextProps.GestureStrokeWidth.Value.Value;
			}
			if (nextProps.GestureVisible.HasValue)
			{
				Element.GestureVisible = nextProps.GestureVisible.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.UncertainGestureColor.HasValue)
			{
				Element.UncertainGestureColor = nextProps.UncertainGestureColor.Value.Value;
			}
			if (!ReferenceEquals(previous?.GestureEvent, null) && ReferenceEquals(nextProps.GestureEvent, null))
			{
				Element.GestureEvent -= nextProps.GestureEvent;
			}
			if (ReferenceEquals(previous?.GestureEvent, null) && !ReferenceEquals(nextProps.GestureEvent, null))
			{
				Element.GestureEvent += nextProps.GestureEvent;
			}
			if (!ReferenceEquals(previous?.GestureCancelled, null) && ReferenceEquals(nextProps.GestureCancelled, null))
			{
				Element.GestureCancelled -= nextProps.GestureCancelled;
			}
			if (ReferenceEquals(previous?.GestureCancelled, null) && !ReferenceEquals(nextProps.GestureCancelled, null))
			{
				Element.GestureCancelled += nextProps.GestureCancelled;
			}
			if (!ReferenceEquals(previous?.GestureEnded, null) && ReferenceEquals(nextProps.GestureEnded, null))
			{
				Element.GestureEnded -= nextProps.GestureEnded;
			}
			if (ReferenceEquals(previous?.GestureEnded, null) && !ReferenceEquals(nextProps.GestureEnded, null))
			{
				Element.GestureEnded += nextProps.GestureEnded;
			}
			if (!ReferenceEquals(previous?.GestureStarted, null) && ReferenceEquals(nextProps.GestureStarted, null))
			{
				Element.GestureStarted -= nextProps.GestureStarted;
			}
			if (ReferenceEquals(previous?.GestureStarted, null) && !ReferenceEquals(nextProps.GestureStarted, null))
			{
				Element.GestureStarted += nextProps.GestureStarted;
			}
			if (!ReferenceEquals(previous?.GesturePerformed, null) && ReferenceEquals(nextProps.GesturePerformed, null))
			{
				Element.GesturePerformed -= nextProps.GesturePerformed;
			}
			if (ReferenceEquals(previous?.GesturePerformed, null) && !ReferenceEquals(nextProps.GesturePerformed, null))
			{
				Element.GesturePerformed += nextProps.GesturePerformed;
			}
			if (!ReferenceEquals(previous?.GesturingEnded, null) && ReferenceEquals(nextProps.GesturingEnded, null))
			{
				Element.GesturingEnded -= nextProps.GesturingEnded;
			}
			if (ReferenceEquals(previous?.GesturingEnded, null) && !ReferenceEquals(nextProps.GesturingEnded, null))
			{
				Element.GesturingEnded += nextProps.GesturingEnded;
			}
			if (!ReferenceEquals(previous?.GesturingStarted, null) && ReferenceEquals(nextProps.GesturingStarted, null))
			{
				Element.GesturingStarted -= nextProps.GesturingStarted;
			}
			if (ReferenceEquals(previous?.GesturingStarted, null) && !ReferenceEquals(nextProps.GesturingStarted, null))
			{
				Element.GesturingStarted += nextProps.GesturingStarted;
			}
		}
	}
}
