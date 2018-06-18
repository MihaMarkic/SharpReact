using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class GestureOverlayView: FrameLayout
	{
		public ReactParam<global::System.Boolean>? EventsInterceptionEnabled { get; set; }
		public ReactParam<global::System.Boolean>? FadeEnabled { get; set; }
		public ReactParam<global::System.Int64>? FadeOffset { get; set; }
		public ReactParam<global::Android.Gestures.Gesture>? Gesture { get; set; }
		public ReactParam<global::Android.Graphics.Color>? GestureColor { get; set; }
		public ReactParam<global::System.Single>? GestureStrokeAngleThreshold { get; set; }
		public ReactParam<global::System.Single>? GestureStrokeLengthThreshold { get; set; }
		public ReactParam<global::System.Single>? GestureStrokeSquarenessTreshold { get; set; }
		public ReactParam<global::Android.Gestures.GestureStrokeType>? GestureStrokeType { get; set; }
		public ReactParam<global::System.Single>? GestureStrokeWidth { get; set; }
		public ReactParam<global::System.Boolean>? GestureVisible { get; set; }
		public ReactParam<global::Android.Gestures.GestureOrientation>? Orientation { get; set; }
		public ReactParam<global::Android.Graphics.Color>? UncertainGestureColor { get; set; }
		public System.EventHandler<global::Android.Gestures.GestureOverlayView.GestureEventArgs> GestureEvent { get; set; }
		public System.EventHandler<global::Android.Gestures.GestureOverlayView.GestureCancelledEventArgs> GestureCancelled { get; set; }
		public System.EventHandler<global::Android.Gestures.GestureOverlayView.GestureEndedEventArgs> GestureEnded { get; set; }
		public System.EventHandler<global::Android.Gestures.GestureOverlayView.GestureStartedEventArgs> GestureStarted { get; set; }
		public System.EventHandler<global::Android.Gestures.GestureOverlayView.GesturePerformedEventArgs> GesturePerformed { get; set; }
		public System.EventHandler<global::Android.Gestures.GestureOverlayView.GesturingEndedEventArgs> GesturingEnded { get; set; }
		public System.EventHandler<global::Android.Gestures.GestureOverlayView.GesturingStartedEventArgs> GesturingStarted { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GestureOverlayView<GestureOverlayView, global::Android.Gestures.GestureOverlayView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return EventsInterceptionEnabled;
				yield return FadeEnabled;
				yield return FadeOffset;
				yield return Gesture;
				yield return GestureColor;
				yield return GestureStrokeAngleThreshold;
				yield return GestureStrokeLengthThreshold;
				yield return GestureStrokeSquarenessTreshold;
				yield return GestureStrokeType;
				yield return GestureStrokeWidth;
				yield return GestureVisible;
				yield return Orientation;
				yield return UncertainGestureColor;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
