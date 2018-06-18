using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class GestureOverlayView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.GestureOverlayView
		where TElement : global::Android.Gestures.GestureOverlayView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Gestures.GestureOverlayView(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateGestureOverlayViewWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateGestureOverlayViewWithInstanceProperties(element, null, props);
		}
		static void UpdateGestureOverlayViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.EventsInterceptionEnabled.HasValue)
			{
				element.EventsInterceptionEnabled = nextProps.EventsInterceptionEnabled.Value.Value;
			}
			if (nextProps.FadeEnabled.HasValue)
			{
				element.FadeEnabled = nextProps.FadeEnabled.Value.Value;
			}
			if (nextProps.FadeOffset.HasValue)
			{
				element.FadeOffset = nextProps.FadeOffset.Value.Value;
			}
			if (nextProps.Gesture.HasValue)
			{
				element.Gesture = nextProps.Gesture.Value.Value;
			}
			if (nextProps.GestureColor.HasValue)
			{
				element.GestureColor = nextProps.GestureColor.Value.Value;
			}
			if (nextProps.GestureStrokeAngleThreshold.HasValue)
			{
				element.GestureStrokeAngleThreshold = nextProps.GestureStrokeAngleThreshold.Value.Value;
			}
			if (nextProps.GestureStrokeLengthThreshold.HasValue)
			{
				element.GestureStrokeLengthThreshold = nextProps.GestureStrokeLengthThreshold.Value.Value;
			}
			if (nextProps.GestureStrokeSquarenessTreshold.HasValue)
			{
				element.GestureStrokeSquarenessTreshold = nextProps.GestureStrokeSquarenessTreshold.Value.Value;
			}
			if (nextProps.GestureStrokeType.HasValue)
			{
				element.GestureStrokeType = nextProps.GestureStrokeType.Value.Value;
			}
			if (nextProps.GestureStrokeWidth.HasValue)
			{
				element.GestureStrokeWidth = nextProps.GestureStrokeWidth.Value.Value;
			}
			if (nextProps.GestureVisible.HasValue)
			{
				element.GestureVisible = nextProps.GestureVisible.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.UncertainGestureColor.HasValue)
			{
				element.UncertainGestureColor = nextProps.UncertainGestureColor.Value.Value;
			}
			if (!(previous?.GestureEvent is null) && nextProps.GestureEvent is null)
			{
				element.GestureEvent -= nextProps.GestureEvent;
			}
			if (previous?.GestureEvent is null && !(nextProps.GestureEvent is null))
			{
				element.GestureEvent += nextProps.GestureEvent;
			}
			if (!(previous?.GestureCancelled is null) && nextProps.GestureCancelled is null)
			{
				element.GestureCancelled -= nextProps.GestureCancelled;
			}
			if (previous?.GestureCancelled is null && !(nextProps.GestureCancelled is null))
			{
				element.GestureCancelled += nextProps.GestureCancelled;
			}
			if (!(previous?.GestureEnded is null) && nextProps.GestureEnded is null)
			{
				element.GestureEnded -= nextProps.GestureEnded;
			}
			if (previous?.GestureEnded is null && !(nextProps.GestureEnded is null))
			{
				element.GestureEnded += nextProps.GestureEnded;
			}
			if (!(previous?.GestureStarted is null) && nextProps.GestureStarted is null)
			{
				element.GestureStarted -= nextProps.GestureStarted;
			}
			if (previous?.GestureStarted is null && !(nextProps.GestureStarted is null))
			{
				element.GestureStarted += nextProps.GestureStarted;
			}
			if (!(previous?.GesturePerformed is null) && nextProps.GesturePerformed is null)
			{
				element.GesturePerformed -= nextProps.GesturePerformed;
			}
			if (previous?.GesturePerformed is null && !(nextProps.GesturePerformed is null))
			{
				element.GesturePerformed += nextProps.GesturePerformed;
			}
			if (!(previous?.GesturingEnded is null) && nextProps.GesturingEnded is null)
			{
				element.GesturingEnded -= nextProps.GesturingEnded;
			}
			if (previous?.GesturingEnded is null && !(nextProps.GesturingEnded is null))
			{
				element.GesturingEnded += nextProps.GesturingEnded;
			}
			if (!(previous?.GesturingStarted is null) && nextProps.GesturingStarted is null)
			{
				element.GesturingStarted -= nextProps.GesturingStarted;
			}
			if (previous?.GesturingStarted is null && !(nextProps.GesturingStarted is null))
			{
				element.GesturingStarted += nextProps.GesturingStarted;
			}
		}
	}
}
