using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class UIElement: Core.Properties.SharpNativeProp
	{
		public ReactParam<global::System.Boolean>? AllowDrop { get; set; }
		public ReactParam<global::System.Windows.Size>? RenderSize { get; set; }
		public ReactParam<global::System.Windows.Media.Transform>? RenderTransform { get; set; }
		public ReactParam<global::System.Windows.Point>? RenderTransformOrigin { get; set; }
		public ReactParam<global::System.Double>? Opacity { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? OpacityMask { get; set; }
		public ReactParam<global::System.Windows.Media.Effects.Effect>? Effect { get; set; }
		public ReactParam<global::System.Windows.Media.CacheMode>? CacheMode { get; set; }
		public ReactParam<global::System.String>? Uid { get; set; }
		public ReactParam<global::System.Windows.Visibility>? Visibility { get; set; }
		public ReactParam<global::System.Boolean>? ClipToBounds { get; set; }
		public ReactParam<global::System.Windows.Media.Geometry>? Clip { get; set; }
		public ReactParam<global::System.Boolean>? SnapsToDevicePixels { get; set; }
		public ReactParam<global::System.Boolean>? IsEnabled { get; set; }
		public ReactParam<global::System.Boolean>? IsHitTestVisible { get; set; }
		public ReactParam<global::System.Boolean>? Focusable { get; set; }
		public ReactParam<global::System.Boolean>? IsManipulationEnabled { get; set; }
		public System.Windows.Input.MouseButtonEventHandler PreviewMouseDown { get; set; }
		public System.Windows.Input.MouseButtonEventHandler MouseDown { get; set; }
		public System.Windows.Input.MouseButtonEventHandler PreviewMouseUp { get; set; }
		public System.Windows.Input.MouseButtonEventHandler MouseUp { get; set; }
		public System.Windows.Input.MouseButtonEventHandler PreviewMouseLeftButtonDown { get; set; }
		public System.Windows.Input.MouseButtonEventHandler MouseLeftButtonDown { get; set; }
		public System.Windows.Input.MouseButtonEventHandler PreviewMouseLeftButtonUp { get; set; }
		public System.Windows.Input.MouseButtonEventHandler MouseLeftButtonUp { get; set; }
		public System.Windows.Input.MouseButtonEventHandler PreviewMouseRightButtonDown { get; set; }
		public System.Windows.Input.MouseButtonEventHandler MouseRightButtonDown { get; set; }
		public System.Windows.Input.MouseButtonEventHandler PreviewMouseRightButtonUp { get; set; }
		public System.Windows.Input.MouseButtonEventHandler MouseRightButtonUp { get; set; }
		public System.Windows.Input.MouseEventHandler PreviewMouseMove { get; set; }
		public System.Windows.Input.MouseEventHandler MouseMove { get; set; }
		public System.Windows.Input.MouseWheelEventHandler PreviewMouseWheel { get; set; }
		public System.Windows.Input.MouseWheelEventHandler MouseWheel { get; set; }
		public System.Windows.Input.MouseEventHandler MouseEnter { get; set; }
		public System.Windows.Input.MouseEventHandler MouseLeave { get; set; }
		public System.Windows.Input.MouseEventHandler GotMouseCapture { get; set; }
		public System.Windows.Input.MouseEventHandler LostMouseCapture { get; set; }
		public System.Windows.Input.QueryCursorEventHandler QueryCursor { get; set; }
		public System.Windows.Input.StylusDownEventHandler PreviewStylusDown { get; set; }
		public System.Windows.Input.StylusDownEventHandler StylusDown { get; set; }
		public System.Windows.Input.StylusEventHandler PreviewStylusUp { get; set; }
		public System.Windows.Input.StylusEventHandler StylusUp { get; set; }
		public System.Windows.Input.StylusEventHandler PreviewStylusMove { get; set; }
		public System.Windows.Input.StylusEventHandler StylusMove { get; set; }
		public System.Windows.Input.StylusEventHandler PreviewStylusInAirMove { get; set; }
		public System.Windows.Input.StylusEventHandler StylusInAirMove { get; set; }
		public System.Windows.Input.StylusEventHandler StylusEnter { get; set; }
		public System.Windows.Input.StylusEventHandler StylusLeave { get; set; }
		public System.Windows.Input.StylusEventHandler PreviewStylusInRange { get; set; }
		public System.Windows.Input.StylusEventHandler StylusInRange { get; set; }
		public System.Windows.Input.StylusEventHandler PreviewStylusOutOfRange { get; set; }
		public System.Windows.Input.StylusEventHandler StylusOutOfRange { get; set; }
		public System.Windows.Input.StylusSystemGestureEventHandler PreviewStylusSystemGesture { get; set; }
		public System.Windows.Input.StylusSystemGestureEventHandler StylusSystemGesture { get; set; }
		public System.Windows.Input.StylusEventHandler GotStylusCapture { get; set; }
		public System.Windows.Input.StylusEventHandler LostStylusCapture { get; set; }
		public System.Windows.Input.StylusButtonEventHandler StylusButtonDown { get; set; }
		public System.Windows.Input.StylusButtonEventHandler StylusButtonUp { get; set; }
		public System.Windows.Input.StylusButtonEventHandler PreviewStylusButtonDown { get; set; }
		public System.Windows.Input.StylusButtonEventHandler PreviewStylusButtonUp { get; set; }
		public System.Windows.Input.KeyEventHandler PreviewKeyDown { get; set; }
		public System.Windows.Input.KeyEventHandler KeyDown { get; set; }
		public System.Windows.Input.KeyEventHandler PreviewKeyUp { get; set; }
		public System.Windows.Input.KeyEventHandler KeyUp { get; set; }
		public System.Windows.Input.KeyboardFocusChangedEventHandler PreviewGotKeyboardFocus { get; set; }
		public System.Windows.Input.KeyboardFocusChangedEventHandler GotKeyboardFocus { get; set; }
		public System.Windows.Input.KeyboardFocusChangedEventHandler PreviewLostKeyboardFocus { get; set; }
		public System.Windows.Input.KeyboardFocusChangedEventHandler LostKeyboardFocus { get; set; }
		public System.Windows.Input.TextCompositionEventHandler PreviewTextInput { get; set; }
		public System.Windows.Input.TextCompositionEventHandler TextInput { get; set; }
		public System.Windows.QueryContinueDragEventHandler PreviewQueryContinueDrag { get; set; }
		public System.Windows.QueryContinueDragEventHandler QueryContinueDrag { get; set; }
		public System.Windows.GiveFeedbackEventHandler PreviewGiveFeedback { get; set; }
		public System.Windows.GiveFeedbackEventHandler GiveFeedback { get; set; }
		public System.Windows.DragEventHandler PreviewDragEnter { get; set; }
		public System.Windows.DragEventHandler DragEnter { get; set; }
		public System.Windows.DragEventHandler PreviewDragOver { get; set; }
		public System.Windows.DragEventHandler DragOver { get; set; }
		public System.Windows.DragEventHandler PreviewDragLeave { get; set; }
		public System.Windows.DragEventHandler DragLeave { get; set; }
		public System.Windows.DragEventHandler PreviewDrop { get; set; }
		public System.Windows.DragEventHandler Drop { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> PreviewTouchDown { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> TouchDown { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> PreviewTouchMove { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> TouchMove { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> PreviewTouchUp { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> TouchUp { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> GotTouchCapture { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> LostTouchCapture { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> TouchEnter { get; set; }
		public System.EventHandler<global::System.Windows.Input.TouchEventArgs> TouchLeave { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsMouseDirectlyOverChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsKeyboardFocusWithinChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsMouseCapturedChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsMouseCaptureWithinChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsStylusDirectlyOverChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsStylusCapturedChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsStylusCaptureWithinChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsKeyboardFocusedChanged { get; set; }
		public System.EventHandler LayoutUpdated { get; set; }
		public System.Windows.RoutedEventHandler GotFocus { get; set; }
		public System.Windows.RoutedEventHandler LostFocus { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsEnabledChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsHitTestVisibleChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler IsVisibleChanged { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler FocusableChanged { get; set; }
		public System.EventHandler<global::System.Windows.Input.ManipulationStartingEventArgs> ManipulationStarting { get; set; }
		public System.EventHandler<global::System.Windows.Input.ManipulationStartedEventArgs> ManipulationStarted { get; set; }
		public System.EventHandler<global::System.Windows.Input.ManipulationDeltaEventArgs> ManipulationDelta { get; set; }
		public System.EventHandler<global::System.Windows.Input.ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting { get; set; }
		public System.EventHandler<global::System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> ManipulationBoundaryFeedback { get; set; }
		public System.EventHandler<global::System.Windows.Input.ManipulationCompletedEventArgs> ManipulationCompleted { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.UIElement<UIElement, System.Windows.UIElement>();
		}
	}
}
