using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class UIElement<TProps, TElement>: SharpWpfComponent<TProps, object, TElement>
		where TProps : Props.UIElement
		where TElement : System.Windows.UIElement, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.AllowDrop.HasValue)
			{
				Element.AllowDrop = nextProps.AllowDrop.Value.Value;
			}
			if (nextProps.RenderSize.HasValue)
			{
				Element.RenderSize = nextProps.RenderSize.Value.Value;
			}
			if (nextProps.RenderTransform.HasValue)
			{
				Element.RenderTransform = nextProps.RenderTransform.Value.Value;
			}
			if (nextProps.RenderTransformOrigin.HasValue)
			{
				Element.RenderTransformOrigin = nextProps.RenderTransformOrigin.Value.Value;
			}
			if (nextProps.Opacity.HasValue)
			{
				Element.Opacity = nextProps.Opacity.Value.Value;
			}
			if (nextProps.OpacityMask.HasValue)
			{
				Element.OpacityMask = nextProps.OpacityMask.Value.Value;
			}
			if (nextProps.Effect.HasValue)
			{
				Element.Effect = nextProps.Effect.Value.Value;
			}
			if (nextProps.CacheMode.HasValue)
			{
				Element.CacheMode = nextProps.CacheMode.Value.Value;
			}
			if (nextProps.Uid.HasValue)
			{
				Element.Uid = nextProps.Uid.Value.Value;
			}
			if (nextProps.Visibility.HasValue)
			{
				Element.Visibility = nextProps.Visibility.Value.Value;
			}
			if (nextProps.ClipToBounds.HasValue)
			{
				Element.ClipToBounds = nextProps.ClipToBounds.Value.Value;
			}
			if (nextProps.Clip.HasValue)
			{
				Element.Clip = nextProps.Clip.Value.Value;
			}
			if (nextProps.SnapsToDevicePixels.HasValue)
			{
				Element.SnapsToDevicePixels = nextProps.SnapsToDevicePixels.Value.Value;
			}
			if (nextProps.IsEnabled.HasValue)
			{
				Element.IsEnabled = nextProps.IsEnabled.Value.Value;
			}
			if (nextProps.IsHitTestVisible.HasValue)
			{
				Element.IsHitTestVisible = nextProps.IsHitTestVisible.Value.Value;
			}
			if (nextProps.Focusable.HasValue)
			{
				Element.Focusable = nextProps.Focusable.Value.Value;
			}
			if (nextProps.IsManipulationEnabled.HasValue)
			{
				Element.IsManipulationEnabled = nextProps.IsManipulationEnabled.Value.Value;
			}
			if (!ReferenceEquals(previous?.PreviewMouseDown, null) && ReferenceEquals(nextProps.PreviewMouseDown, null))
			{
				Element.PreviewMouseDown -= nextProps.PreviewMouseDown;
			}
			if (ReferenceEquals(previous?.PreviewMouseDown, null) && !ReferenceEquals(nextProps.PreviewMouseDown, null))
			{
				Element.PreviewMouseDown += nextProps.PreviewMouseDown;
			}
			if (!ReferenceEquals(previous?.MouseDown, null) && ReferenceEquals(nextProps.MouseDown, null))
			{
				Element.MouseDown -= nextProps.MouseDown;
			}
			if (ReferenceEquals(previous?.MouseDown, null) && !ReferenceEquals(nextProps.MouseDown, null))
			{
				Element.MouseDown += nextProps.MouseDown;
			}
			if (!ReferenceEquals(previous?.PreviewMouseUp, null) && ReferenceEquals(nextProps.PreviewMouseUp, null))
			{
				Element.PreviewMouseUp -= nextProps.PreviewMouseUp;
			}
			if (ReferenceEquals(previous?.PreviewMouseUp, null) && !ReferenceEquals(nextProps.PreviewMouseUp, null))
			{
				Element.PreviewMouseUp += nextProps.PreviewMouseUp;
			}
			if (!ReferenceEquals(previous?.MouseUp, null) && ReferenceEquals(nextProps.MouseUp, null))
			{
				Element.MouseUp -= nextProps.MouseUp;
			}
			if (ReferenceEquals(previous?.MouseUp, null) && !ReferenceEquals(nextProps.MouseUp, null))
			{
				Element.MouseUp += nextProps.MouseUp;
			}
			if (!ReferenceEquals(previous?.PreviewMouseLeftButtonDown, null) && ReferenceEquals(nextProps.PreviewMouseLeftButtonDown, null))
			{
				Element.PreviewMouseLeftButtonDown -= nextProps.PreviewMouseLeftButtonDown;
			}
			if (ReferenceEquals(previous?.PreviewMouseLeftButtonDown, null) && !ReferenceEquals(nextProps.PreviewMouseLeftButtonDown, null))
			{
				Element.PreviewMouseLeftButtonDown += nextProps.PreviewMouseLeftButtonDown;
			}
			if (!ReferenceEquals(previous?.MouseLeftButtonDown, null) && ReferenceEquals(nextProps.MouseLeftButtonDown, null))
			{
				Element.MouseLeftButtonDown -= nextProps.MouseLeftButtonDown;
			}
			if (ReferenceEquals(previous?.MouseLeftButtonDown, null) && !ReferenceEquals(nextProps.MouseLeftButtonDown, null))
			{
				Element.MouseLeftButtonDown += nextProps.MouseLeftButtonDown;
			}
			if (!ReferenceEquals(previous?.PreviewMouseLeftButtonUp, null) && ReferenceEquals(nextProps.PreviewMouseLeftButtonUp, null))
			{
				Element.PreviewMouseLeftButtonUp -= nextProps.PreviewMouseLeftButtonUp;
			}
			if (ReferenceEquals(previous?.PreviewMouseLeftButtonUp, null) && !ReferenceEquals(nextProps.PreviewMouseLeftButtonUp, null))
			{
				Element.PreviewMouseLeftButtonUp += nextProps.PreviewMouseLeftButtonUp;
			}
			if (!ReferenceEquals(previous?.MouseLeftButtonUp, null) && ReferenceEquals(nextProps.MouseLeftButtonUp, null))
			{
				Element.MouseLeftButtonUp -= nextProps.MouseLeftButtonUp;
			}
			if (ReferenceEquals(previous?.MouseLeftButtonUp, null) && !ReferenceEquals(nextProps.MouseLeftButtonUp, null))
			{
				Element.MouseLeftButtonUp += nextProps.MouseLeftButtonUp;
			}
			if (!ReferenceEquals(previous?.PreviewMouseRightButtonDown, null) && ReferenceEquals(nextProps.PreviewMouseRightButtonDown, null))
			{
				Element.PreviewMouseRightButtonDown -= nextProps.PreviewMouseRightButtonDown;
			}
			if (ReferenceEquals(previous?.PreviewMouseRightButtonDown, null) && !ReferenceEquals(nextProps.PreviewMouseRightButtonDown, null))
			{
				Element.PreviewMouseRightButtonDown += nextProps.PreviewMouseRightButtonDown;
			}
			if (!ReferenceEquals(previous?.MouseRightButtonDown, null) && ReferenceEquals(nextProps.MouseRightButtonDown, null))
			{
				Element.MouseRightButtonDown -= nextProps.MouseRightButtonDown;
			}
			if (ReferenceEquals(previous?.MouseRightButtonDown, null) && !ReferenceEquals(nextProps.MouseRightButtonDown, null))
			{
				Element.MouseRightButtonDown += nextProps.MouseRightButtonDown;
			}
			if (!ReferenceEquals(previous?.PreviewMouseRightButtonUp, null) && ReferenceEquals(nextProps.PreviewMouseRightButtonUp, null))
			{
				Element.PreviewMouseRightButtonUp -= nextProps.PreviewMouseRightButtonUp;
			}
			if (ReferenceEquals(previous?.PreviewMouseRightButtonUp, null) && !ReferenceEquals(nextProps.PreviewMouseRightButtonUp, null))
			{
				Element.PreviewMouseRightButtonUp += nextProps.PreviewMouseRightButtonUp;
			}
			if (!ReferenceEquals(previous?.MouseRightButtonUp, null) && ReferenceEquals(nextProps.MouseRightButtonUp, null))
			{
				Element.MouseRightButtonUp -= nextProps.MouseRightButtonUp;
			}
			if (ReferenceEquals(previous?.MouseRightButtonUp, null) && !ReferenceEquals(nextProps.MouseRightButtonUp, null))
			{
				Element.MouseRightButtonUp += nextProps.MouseRightButtonUp;
			}
			if (!ReferenceEquals(previous?.PreviewMouseMove, null) && ReferenceEquals(nextProps.PreviewMouseMove, null))
			{
				Element.PreviewMouseMove -= nextProps.PreviewMouseMove;
			}
			if (ReferenceEquals(previous?.PreviewMouseMove, null) && !ReferenceEquals(nextProps.PreviewMouseMove, null))
			{
				Element.PreviewMouseMove += nextProps.PreviewMouseMove;
			}
			if (!ReferenceEquals(previous?.MouseMove, null) && ReferenceEquals(nextProps.MouseMove, null))
			{
				Element.MouseMove -= nextProps.MouseMove;
			}
			if (ReferenceEquals(previous?.MouseMove, null) && !ReferenceEquals(nextProps.MouseMove, null))
			{
				Element.MouseMove += nextProps.MouseMove;
			}
			if (!ReferenceEquals(previous?.PreviewMouseWheel, null) && ReferenceEquals(nextProps.PreviewMouseWheel, null))
			{
				Element.PreviewMouseWheel -= nextProps.PreviewMouseWheel;
			}
			if (ReferenceEquals(previous?.PreviewMouseWheel, null) && !ReferenceEquals(nextProps.PreviewMouseWheel, null))
			{
				Element.PreviewMouseWheel += nextProps.PreviewMouseWheel;
			}
			if (!ReferenceEquals(previous?.MouseWheel, null) && ReferenceEquals(nextProps.MouseWheel, null))
			{
				Element.MouseWheel -= nextProps.MouseWheel;
			}
			if (ReferenceEquals(previous?.MouseWheel, null) && !ReferenceEquals(nextProps.MouseWheel, null))
			{
				Element.MouseWheel += nextProps.MouseWheel;
			}
			if (!ReferenceEquals(previous?.MouseEnter, null) && ReferenceEquals(nextProps.MouseEnter, null))
			{
				Element.MouseEnter -= nextProps.MouseEnter;
			}
			if (ReferenceEquals(previous?.MouseEnter, null) && !ReferenceEquals(nextProps.MouseEnter, null))
			{
				Element.MouseEnter += nextProps.MouseEnter;
			}
			if (!ReferenceEquals(previous?.MouseLeave, null) && ReferenceEquals(nextProps.MouseLeave, null))
			{
				Element.MouseLeave -= nextProps.MouseLeave;
			}
			if (ReferenceEquals(previous?.MouseLeave, null) && !ReferenceEquals(nextProps.MouseLeave, null))
			{
				Element.MouseLeave += nextProps.MouseLeave;
			}
			if (!ReferenceEquals(previous?.GotMouseCapture, null) && ReferenceEquals(nextProps.GotMouseCapture, null))
			{
				Element.GotMouseCapture -= nextProps.GotMouseCapture;
			}
			if (ReferenceEquals(previous?.GotMouseCapture, null) && !ReferenceEquals(nextProps.GotMouseCapture, null))
			{
				Element.GotMouseCapture += nextProps.GotMouseCapture;
			}
			if (!ReferenceEquals(previous?.LostMouseCapture, null) && ReferenceEquals(nextProps.LostMouseCapture, null))
			{
				Element.LostMouseCapture -= nextProps.LostMouseCapture;
			}
			if (ReferenceEquals(previous?.LostMouseCapture, null) && !ReferenceEquals(nextProps.LostMouseCapture, null))
			{
				Element.LostMouseCapture += nextProps.LostMouseCapture;
			}
			if (!ReferenceEquals(previous?.QueryCursor, null) && ReferenceEquals(nextProps.QueryCursor, null))
			{
				Element.QueryCursor -= nextProps.QueryCursor;
			}
			if (ReferenceEquals(previous?.QueryCursor, null) && !ReferenceEquals(nextProps.QueryCursor, null))
			{
				Element.QueryCursor += nextProps.QueryCursor;
			}
			if (!ReferenceEquals(previous?.PreviewStylusDown, null) && ReferenceEquals(nextProps.PreviewStylusDown, null))
			{
				Element.PreviewStylusDown -= nextProps.PreviewStylusDown;
			}
			if (ReferenceEquals(previous?.PreviewStylusDown, null) && !ReferenceEquals(nextProps.PreviewStylusDown, null))
			{
				Element.PreviewStylusDown += nextProps.PreviewStylusDown;
			}
			if (!ReferenceEquals(previous?.StylusDown, null) && ReferenceEquals(nextProps.StylusDown, null))
			{
				Element.StylusDown -= nextProps.StylusDown;
			}
			if (ReferenceEquals(previous?.StylusDown, null) && !ReferenceEquals(nextProps.StylusDown, null))
			{
				Element.StylusDown += nextProps.StylusDown;
			}
			if (!ReferenceEquals(previous?.PreviewStylusUp, null) && ReferenceEquals(nextProps.PreviewStylusUp, null))
			{
				Element.PreviewStylusUp -= nextProps.PreviewStylusUp;
			}
			if (ReferenceEquals(previous?.PreviewStylusUp, null) && !ReferenceEquals(nextProps.PreviewStylusUp, null))
			{
				Element.PreviewStylusUp += nextProps.PreviewStylusUp;
			}
			if (!ReferenceEquals(previous?.StylusUp, null) && ReferenceEquals(nextProps.StylusUp, null))
			{
				Element.StylusUp -= nextProps.StylusUp;
			}
			if (ReferenceEquals(previous?.StylusUp, null) && !ReferenceEquals(nextProps.StylusUp, null))
			{
				Element.StylusUp += nextProps.StylusUp;
			}
			if (!ReferenceEquals(previous?.PreviewStylusMove, null) && ReferenceEquals(nextProps.PreviewStylusMove, null))
			{
				Element.PreviewStylusMove -= nextProps.PreviewStylusMove;
			}
			if (ReferenceEquals(previous?.PreviewStylusMove, null) && !ReferenceEquals(nextProps.PreviewStylusMove, null))
			{
				Element.PreviewStylusMove += nextProps.PreviewStylusMove;
			}
			if (!ReferenceEquals(previous?.StylusMove, null) && ReferenceEquals(nextProps.StylusMove, null))
			{
				Element.StylusMove -= nextProps.StylusMove;
			}
			if (ReferenceEquals(previous?.StylusMove, null) && !ReferenceEquals(nextProps.StylusMove, null))
			{
				Element.StylusMove += nextProps.StylusMove;
			}
			if (!ReferenceEquals(previous?.PreviewStylusInAirMove, null) && ReferenceEquals(nextProps.PreviewStylusInAirMove, null))
			{
				Element.PreviewStylusInAirMove -= nextProps.PreviewStylusInAirMove;
			}
			if (ReferenceEquals(previous?.PreviewStylusInAirMove, null) && !ReferenceEquals(nextProps.PreviewStylusInAirMove, null))
			{
				Element.PreviewStylusInAirMove += nextProps.PreviewStylusInAirMove;
			}
			if (!ReferenceEquals(previous?.StylusInAirMove, null) && ReferenceEquals(nextProps.StylusInAirMove, null))
			{
				Element.StylusInAirMove -= nextProps.StylusInAirMove;
			}
			if (ReferenceEquals(previous?.StylusInAirMove, null) && !ReferenceEquals(nextProps.StylusInAirMove, null))
			{
				Element.StylusInAirMove += nextProps.StylusInAirMove;
			}
			if (!ReferenceEquals(previous?.StylusEnter, null) && ReferenceEquals(nextProps.StylusEnter, null))
			{
				Element.StylusEnter -= nextProps.StylusEnter;
			}
			if (ReferenceEquals(previous?.StylusEnter, null) && !ReferenceEquals(nextProps.StylusEnter, null))
			{
				Element.StylusEnter += nextProps.StylusEnter;
			}
			if (!ReferenceEquals(previous?.StylusLeave, null) && ReferenceEquals(nextProps.StylusLeave, null))
			{
				Element.StylusLeave -= nextProps.StylusLeave;
			}
			if (ReferenceEquals(previous?.StylusLeave, null) && !ReferenceEquals(nextProps.StylusLeave, null))
			{
				Element.StylusLeave += nextProps.StylusLeave;
			}
			if (!ReferenceEquals(previous?.PreviewStylusInRange, null) && ReferenceEquals(nextProps.PreviewStylusInRange, null))
			{
				Element.PreviewStylusInRange -= nextProps.PreviewStylusInRange;
			}
			if (ReferenceEquals(previous?.PreviewStylusInRange, null) && !ReferenceEquals(nextProps.PreviewStylusInRange, null))
			{
				Element.PreviewStylusInRange += nextProps.PreviewStylusInRange;
			}
			if (!ReferenceEquals(previous?.StylusInRange, null) && ReferenceEquals(nextProps.StylusInRange, null))
			{
				Element.StylusInRange -= nextProps.StylusInRange;
			}
			if (ReferenceEquals(previous?.StylusInRange, null) && !ReferenceEquals(nextProps.StylusInRange, null))
			{
				Element.StylusInRange += nextProps.StylusInRange;
			}
			if (!ReferenceEquals(previous?.PreviewStylusOutOfRange, null) && ReferenceEquals(nextProps.PreviewStylusOutOfRange, null))
			{
				Element.PreviewStylusOutOfRange -= nextProps.PreviewStylusOutOfRange;
			}
			if (ReferenceEquals(previous?.PreviewStylusOutOfRange, null) && !ReferenceEquals(nextProps.PreviewStylusOutOfRange, null))
			{
				Element.PreviewStylusOutOfRange += nextProps.PreviewStylusOutOfRange;
			}
			if (!ReferenceEquals(previous?.StylusOutOfRange, null) && ReferenceEquals(nextProps.StylusOutOfRange, null))
			{
				Element.StylusOutOfRange -= nextProps.StylusOutOfRange;
			}
			if (ReferenceEquals(previous?.StylusOutOfRange, null) && !ReferenceEquals(nextProps.StylusOutOfRange, null))
			{
				Element.StylusOutOfRange += nextProps.StylusOutOfRange;
			}
			if (!ReferenceEquals(previous?.PreviewStylusSystemGesture, null) && ReferenceEquals(nextProps.PreviewStylusSystemGesture, null))
			{
				Element.PreviewStylusSystemGesture -= nextProps.PreviewStylusSystemGesture;
			}
			if (ReferenceEquals(previous?.PreviewStylusSystemGesture, null) && !ReferenceEquals(nextProps.PreviewStylusSystemGesture, null))
			{
				Element.PreviewStylusSystemGesture += nextProps.PreviewStylusSystemGesture;
			}
			if (!ReferenceEquals(previous?.StylusSystemGesture, null) && ReferenceEquals(nextProps.StylusSystemGesture, null))
			{
				Element.StylusSystemGesture -= nextProps.StylusSystemGesture;
			}
			if (ReferenceEquals(previous?.StylusSystemGesture, null) && !ReferenceEquals(nextProps.StylusSystemGesture, null))
			{
				Element.StylusSystemGesture += nextProps.StylusSystemGesture;
			}
			if (!ReferenceEquals(previous?.GotStylusCapture, null) && ReferenceEquals(nextProps.GotStylusCapture, null))
			{
				Element.GotStylusCapture -= nextProps.GotStylusCapture;
			}
			if (ReferenceEquals(previous?.GotStylusCapture, null) && !ReferenceEquals(nextProps.GotStylusCapture, null))
			{
				Element.GotStylusCapture += nextProps.GotStylusCapture;
			}
			if (!ReferenceEquals(previous?.LostStylusCapture, null) && ReferenceEquals(nextProps.LostStylusCapture, null))
			{
				Element.LostStylusCapture -= nextProps.LostStylusCapture;
			}
			if (ReferenceEquals(previous?.LostStylusCapture, null) && !ReferenceEquals(nextProps.LostStylusCapture, null))
			{
				Element.LostStylusCapture += nextProps.LostStylusCapture;
			}
			if (!ReferenceEquals(previous?.StylusButtonDown, null) && ReferenceEquals(nextProps.StylusButtonDown, null))
			{
				Element.StylusButtonDown -= nextProps.StylusButtonDown;
			}
			if (ReferenceEquals(previous?.StylusButtonDown, null) && !ReferenceEquals(nextProps.StylusButtonDown, null))
			{
				Element.StylusButtonDown += nextProps.StylusButtonDown;
			}
			if (!ReferenceEquals(previous?.StylusButtonUp, null) && ReferenceEquals(nextProps.StylusButtonUp, null))
			{
				Element.StylusButtonUp -= nextProps.StylusButtonUp;
			}
			if (ReferenceEquals(previous?.StylusButtonUp, null) && !ReferenceEquals(nextProps.StylusButtonUp, null))
			{
				Element.StylusButtonUp += nextProps.StylusButtonUp;
			}
			if (!ReferenceEquals(previous?.PreviewStylusButtonDown, null) && ReferenceEquals(nextProps.PreviewStylusButtonDown, null))
			{
				Element.PreviewStylusButtonDown -= nextProps.PreviewStylusButtonDown;
			}
			if (ReferenceEquals(previous?.PreviewStylusButtonDown, null) && !ReferenceEquals(nextProps.PreviewStylusButtonDown, null))
			{
				Element.PreviewStylusButtonDown += nextProps.PreviewStylusButtonDown;
			}
			if (!ReferenceEquals(previous?.PreviewStylusButtonUp, null) && ReferenceEquals(nextProps.PreviewStylusButtonUp, null))
			{
				Element.PreviewStylusButtonUp -= nextProps.PreviewStylusButtonUp;
			}
			if (ReferenceEquals(previous?.PreviewStylusButtonUp, null) && !ReferenceEquals(nextProps.PreviewStylusButtonUp, null))
			{
				Element.PreviewStylusButtonUp += nextProps.PreviewStylusButtonUp;
			}
			if (!ReferenceEquals(previous?.PreviewKeyDown, null) && ReferenceEquals(nextProps.PreviewKeyDown, null))
			{
				Element.PreviewKeyDown -= nextProps.PreviewKeyDown;
			}
			if (ReferenceEquals(previous?.PreviewKeyDown, null) && !ReferenceEquals(nextProps.PreviewKeyDown, null))
			{
				Element.PreviewKeyDown += nextProps.PreviewKeyDown;
			}
			if (!ReferenceEquals(previous?.KeyDown, null) && ReferenceEquals(nextProps.KeyDown, null))
			{
				Element.KeyDown -= nextProps.KeyDown;
			}
			if (ReferenceEquals(previous?.KeyDown, null) && !ReferenceEquals(nextProps.KeyDown, null))
			{
				Element.KeyDown += nextProps.KeyDown;
			}
			if (!ReferenceEquals(previous?.PreviewKeyUp, null) && ReferenceEquals(nextProps.PreviewKeyUp, null))
			{
				Element.PreviewKeyUp -= nextProps.PreviewKeyUp;
			}
			if (ReferenceEquals(previous?.PreviewKeyUp, null) && !ReferenceEquals(nextProps.PreviewKeyUp, null))
			{
				Element.PreviewKeyUp += nextProps.PreviewKeyUp;
			}
			if (!ReferenceEquals(previous?.KeyUp, null) && ReferenceEquals(nextProps.KeyUp, null))
			{
				Element.KeyUp -= nextProps.KeyUp;
			}
			if (ReferenceEquals(previous?.KeyUp, null) && !ReferenceEquals(nextProps.KeyUp, null))
			{
				Element.KeyUp += nextProps.KeyUp;
			}
			if (!ReferenceEquals(previous?.PreviewGotKeyboardFocus, null) && ReferenceEquals(nextProps.PreviewGotKeyboardFocus, null))
			{
				Element.PreviewGotKeyboardFocus -= nextProps.PreviewGotKeyboardFocus;
			}
			if (ReferenceEquals(previous?.PreviewGotKeyboardFocus, null) && !ReferenceEquals(nextProps.PreviewGotKeyboardFocus, null))
			{
				Element.PreviewGotKeyboardFocus += nextProps.PreviewGotKeyboardFocus;
			}
			if (!ReferenceEquals(previous?.GotKeyboardFocus, null) && ReferenceEquals(nextProps.GotKeyboardFocus, null))
			{
				Element.GotKeyboardFocus -= nextProps.GotKeyboardFocus;
			}
			if (ReferenceEquals(previous?.GotKeyboardFocus, null) && !ReferenceEquals(nextProps.GotKeyboardFocus, null))
			{
				Element.GotKeyboardFocus += nextProps.GotKeyboardFocus;
			}
			if (!ReferenceEquals(previous?.PreviewLostKeyboardFocus, null) && ReferenceEquals(nextProps.PreviewLostKeyboardFocus, null))
			{
				Element.PreviewLostKeyboardFocus -= nextProps.PreviewLostKeyboardFocus;
			}
			if (ReferenceEquals(previous?.PreviewLostKeyboardFocus, null) && !ReferenceEquals(nextProps.PreviewLostKeyboardFocus, null))
			{
				Element.PreviewLostKeyboardFocus += nextProps.PreviewLostKeyboardFocus;
			}
			if (!ReferenceEquals(previous?.LostKeyboardFocus, null) && ReferenceEquals(nextProps.LostKeyboardFocus, null))
			{
				Element.LostKeyboardFocus -= nextProps.LostKeyboardFocus;
			}
			if (ReferenceEquals(previous?.LostKeyboardFocus, null) && !ReferenceEquals(nextProps.LostKeyboardFocus, null))
			{
				Element.LostKeyboardFocus += nextProps.LostKeyboardFocus;
			}
			if (!ReferenceEquals(previous?.PreviewTextInput, null) && ReferenceEquals(nextProps.PreviewTextInput, null))
			{
				Element.PreviewTextInput -= nextProps.PreviewTextInput;
			}
			if (ReferenceEquals(previous?.PreviewTextInput, null) && !ReferenceEquals(nextProps.PreviewTextInput, null))
			{
				Element.PreviewTextInput += nextProps.PreviewTextInput;
			}
			if (!ReferenceEquals(previous?.TextInput, null) && ReferenceEquals(nextProps.TextInput, null))
			{
				Element.TextInput -= nextProps.TextInput;
			}
			if (ReferenceEquals(previous?.TextInput, null) && !ReferenceEquals(nextProps.TextInput, null))
			{
				Element.TextInput += nextProps.TextInput;
			}
			if (!ReferenceEquals(previous?.PreviewQueryContinueDrag, null) && ReferenceEquals(nextProps.PreviewQueryContinueDrag, null))
			{
				Element.PreviewQueryContinueDrag -= nextProps.PreviewQueryContinueDrag;
			}
			if (ReferenceEquals(previous?.PreviewQueryContinueDrag, null) && !ReferenceEquals(nextProps.PreviewQueryContinueDrag, null))
			{
				Element.PreviewQueryContinueDrag += nextProps.PreviewQueryContinueDrag;
			}
			if (!ReferenceEquals(previous?.QueryContinueDrag, null) && ReferenceEquals(nextProps.QueryContinueDrag, null))
			{
				Element.QueryContinueDrag -= nextProps.QueryContinueDrag;
			}
			if (ReferenceEquals(previous?.QueryContinueDrag, null) && !ReferenceEquals(nextProps.QueryContinueDrag, null))
			{
				Element.QueryContinueDrag += nextProps.QueryContinueDrag;
			}
			if (!ReferenceEquals(previous?.PreviewGiveFeedback, null) && ReferenceEquals(nextProps.PreviewGiveFeedback, null))
			{
				Element.PreviewGiveFeedback -= nextProps.PreviewGiveFeedback;
			}
			if (ReferenceEquals(previous?.PreviewGiveFeedback, null) && !ReferenceEquals(nextProps.PreviewGiveFeedback, null))
			{
				Element.PreviewGiveFeedback += nextProps.PreviewGiveFeedback;
			}
			if (!ReferenceEquals(previous?.GiveFeedback, null) && ReferenceEquals(nextProps.GiveFeedback, null))
			{
				Element.GiveFeedback -= nextProps.GiveFeedback;
			}
			if (ReferenceEquals(previous?.GiveFeedback, null) && !ReferenceEquals(nextProps.GiveFeedback, null))
			{
				Element.GiveFeedback += nextProps.GiveFeedback;
			}
			if (!ReferenceEquals(previous?.PreviewDragEnter, null) && ReferenceEquals(nextProps.PreviewDragEnter, null))
			{
				Element.PreviewDragEnter -= nextProps.PreviewDragEnter;
			}
			if (ReferenceEquals(previous?.PreviewDragEnter, null) && !ReferenceEquals(nextProps.PreviewDragEnter, null))
			{
				Element.PreviewDragEnter += nextProps.PreviewDragEnter;
			}
			if (!ReferenceEquals(previous?.DragEnter, null) && ReferenceEquals(nextProps.DragEnter, null))
			{
				Element.DragEnter -= nextProps.DragEnter;
			}
			if (ReferenceEquals(previous?.DragEnter, null) && !ReferenceEquals(nextProps.DragEnter, null))
			{
				Element.DragEnter += nextProps.DragEnter;
			}
			if (!ReferenceEquals(previous?.PreviewDragOver, null) && ReferenceEquals(nextProps.PreviewDragOver, null))
			{
				Element.PreviewDragOver -= nextProps.PreviewDragOver;
			}
			if (ReferenceEquals(previous?.PreviewDragOver, null) && !ReferenceEquals(nextProps.PreviewDragOver, null))
			{
				Element.PreviewDragOver += nextProps.PreviewDragOver;
			}
			if (!ReferenceEquals(previous?.DragOver, null) && ReferenceEquals(nextProps.DragOver, null))
			{
				Element.DragOver -= nextProps.DragOver;
			}
			if (ReferenceEquals(previous?.DragOver, null) && !ReferenceEquals(nextProps.DragOver, null))
			{
				Element.DragOver += nextProps.DragOver;
			}
			if (!ReferenceEquals(previous?.PreviewDragLeave, null) && ReferenceEquals(nextProps.PreviewDragLeave, null))
			{
				Element.PreviewDragLeave -= nextProps.PreviewDragLeave;
			}
			if (ReferenceEquals(previous?.PreviewDragLeave, null) && !ReferenceEquals(nextProps.PreviewDragLeave, null))
			{
				Element.PreviewDragLeave += nextProps.PreviewDragLeave;
			}
			if (!ReferenceEquals(previous?.DragLeave, null) && ReferenceEquals(nextProps.DragLeave, null))
			{
				Element.DragLeave -= nextProps.DragLeave;
			}
			if (ReferenceEquals(previous?.DragLeave, null) && !ReferenceEquals(nextProps.DragLeave, null))
			{
				Element.DragLeave += nextProps.DragLeave;
			}
			if (!ReferenceEquals(previous?.PreviewDrop, null) && ReferenceEquals(nextProps.PreviewDrop, null))
			{
				Element.PreviewDrop -= nextProps.PreviewDrop;
			}
			if (ReferenceEquals(previous?.PreviewDrop, null) && !ReferenceEquals(nextProps.PreviewDrop, null))
			{
				Element.PreviewDrop += nextProps.PreviewDrop;
			}
			if (!ReferenceEquals(previous?.Drop, null) && ReferenceEquals(nextProps.Drop, null))
			{
				Element.Drop -= nextProps.Drop;
			}
			if (ReferenceEquals(previous?.Drop, null) && !ReferenceEquals(nextProps.Drop, null))
			{
				Element.Drop += nextProps.Drop;
			}
			if (!ReferenceEquals(previous?.PreviewTouchDown, null) && ReferenceEquals(nextProps.PreviewTouchDown, null))
			{
				Element.PreviewTouchDown -= nextProps.PreviewTouchDown;
			}
			if (ReferenceEquals(previous?.PreviewTouchDown, null) && !ReferenceEquals(nextProps.PreviewTouchDown, null))
			{
				Element.PreviewTouchDown += nextProps.PreviewTouchDown;
			}
			if (!ReferenceEquals(previous?.TouchDown, null) && ReferenceEquals(nextProps.TouchDown, null))
			{
				Element.TouchDown -= nextProps.TouchDown;
			}
			if (ReferenceEquals(previous?.TouchDown, null) && !ReferenceEquals(nextProps.TouchDown, null))
			{
				Element.TouchDown += nextProps.TouchDown;
			}
			if (!ReferenceEquals(previous?.PreviewTouchMove, null) && ReferenceEquals(nextProps.PreviewTouchMove, null))
			{
				Element.PreviewTouchMove -= nextProps.PreviewTouchMove;
			}
			if (ReferenceEquals(previous?.PreviewTouchMove, null) && !ReferenceEquals(nextProps.PreviewTouchMove, null))
			{
				Element.PreviewTouchMove += nextProps.PreviewTouchMove;
			}
			if (!ReferenceEquals(previous?.TouchMove, null) && ReferenceEquals(nextProps.TouchMove, null))
			{
				Element.TouchMove -= nextProps.TouchMove;
			}
			if (ReferenceEquals(previous?.TouchMove, null) && !ReferenceEquals(nextProps.TouchMove, null))
			{
				Element.TouchMove += nextProps.TouchMove;
			}
			if (!ReferenceEquals(previous?.PreviewTouchUp, null) && ReferenceEquals(nextProps.PreviewTouchUp, null))
			{
				Element.PreviewTouchUp -= nextProps.PreviewTouchUp;
			}
			if (ReferenceEquals(previous?.PreviewTouchUp, null) && !ReferenceEquals(nextProps.PreviewTouchUp, null))
			{
				Element.PreviewTouchUp += nextProps.PreviewTouchUp;
			}
			if (!ReferenceEquals(previous?.TouchUp, null) && ReferenceEquals(nextProps.TouchUp, null))
			{
				Element.TouchUp -= nextProps.TouchUp;
			}
			if (ReferenceEquals(previous?.TouchUp, null) && !ReferenceEquals(nextProps.TouchUp, null))
			{
				Element.TouchUp += nextProps.TouchUp;
			}
			if (!ReferenceEquals(previous?.GotTouchCapture, null) && ReferenceEquals(nextProps.GotTouchCapture, null))
			{
				Element.GotTouchCapture -= nextProps.GotTouchCapture;
			}
			if (ReferenceEquals(previous?.GotTouchCapture, null) && !ReferenceEquals(nextProps.GotTouchCapture, null))
			{
				Element.GotTouchCapture += nextProps.GotTouchCapture;
			}
			if (!ReferenceEquals(previous?.LostTouchCapture, null) && ReferenceEquals(nextProps.LostTouchCapture, null))
			{
				Element.LostTouchCapture -= nextProps.LostTouchCapture;
			}
			if (ReferenceEquals(previous?.LostTouchCapture, null) && !ReferenceEquals(nextProps.LostTouchCapture, null))
			{
				Element.LostTouchCapture += nextProps.LostTouchCapture;
			}
			if (!ReferenceEquals(previous?.TouchEnter, null) && ReferenceEquals(nextProps.TouchEnter, null))
			{
				Element.TouchEnter -= nextProps.TouchEnter;
			}
			if (ReferenceEquals(previous?.TouchEnter, null) && !ReferenceEquals(nextProps.TouchEnter, null))
			{
				Element.TouchEnter += nextProps.TouchEnter;
			}
			if (!ReferenceEquals(previous?.TouchLeave, null) && ReferenceEquals(nextProps.TouchLeave, null))
			{
				Element.TouchLeave -= nextProps.TouchLeave;
			}
			if (ReferenceEquals(previous?.TouchLeave, null) && !ReferenceEquals(nextProps.TouchLeave, null))
			{
				Element.TouchLeave += nextProps.TouchLeave;
			}
			if (!ReferenceEquals(previous?.IsMouseDirectlyOverChanged, null) && ReferenceEquals(nextProps.IsMouseDirectlyOverChanged, null))
			{
				Element.IsMouseDirectlyOverChanged -= nextProps.IsMouseDirectlyOverChanged;
			}
			if (ReferenceEquals(previous?.IsMouseDirectlyOverChanged, null) && !ReferenceEquals(nextProps.IsMouseDirectlyOverChanged, null))
			{
				Element.IsMouseDirectlyOverChanged += nextProps.IsMouseDirectlyOverChanged;
			}
			if (!ReferenceEquals(previous?.IsKeyboardFocusWithinChanged, null) && ReferenceEquals(nextProps.IsKeyboardFocusWithinChanged, null))
			{
				Element.IsKeyboardFocusWithinChanged -= nextProps.IsKeyboardFocusWithinChanged;
			}
			if (ReferenceEquals(previous?.IsKeyboardFocusWithinChanged, null) && !ReferenceEquals(nextProps.IsKeyboardFocusWithinChanged, null))
			{
				Element.IsKeyboardFocusWithinChanged += nextProps.IsKeyboardFocusWithinChanged;
			}
			if (!ReferenceEquals(previous?.IsMouseCapturedChanged, null) && ReferenceEquals(nextProps.IsMouseCapturedChanged, null))
			{
				Element.IsMouseCapturedChanged -= nextProps.IsMouseCapturedChanged;
			}
			if (ReferenceEquals(previous?.IsMouseCapturedChanged, null) && !ReferenceEquals(nextProps.IsMouseCapturedChanged, null))
			{
				Element.IsMouseCapturedChanged += nextProps.IsMouseCapturedChanged;
			}
			if (!ReferenceEquals(previous?.IsMouseCaptureWithinChanged, null) && ReferenceEquals(nextProps.IsMouseCaptureWithinChanged, null))
			{
				Element.IsMouseCaptureWithinChanged -= nextProps.IsMouseCaptureWithinChanged;
			}
			if (ReferenceEquals(previous?.IsMouseCaptureWithinChanged, null) && !ReferenceEquals(nextProps.IsMouseCaptureWithinChanged, null))
			{
				Element.IsMouseCaptureWithinChanged += nextProps.IsMouseCaptureWithinChanged;
			}
			if (!ReferenceEquals(previous?.IsStylusDirectlyOverChanged, null) && ReferenceEquals(nextProps.IsStylusDirectlyOverChanged, null))
			{
				Element.IsStylusDirectlyOverChanged -= nextProps.IsStylusDirectlyOverChanged;
			}
			if (ReferenceEquals(previous?.IsStylusDirectlyOverChanged, null) && !ReferenceEquals(nextProps.IsStylusDirectlyOverChanged, null))
			{
				Element.IsStylusDirectlyOverChanged += nextProps.IsStylusDirectlyOverChanged;
			}
			if (!ReferenceEquals(previous?.IsStylusCapturedChanged, null) && ReferenceEquals(nextProps.IsStylusCapturedChanged, null))
			{
				Element.IsStylusCapturedChanged -= nextProps.IsStylusCapturedChanged;
			}
			if (ReferenceEquals(previous?.IsStylusCapturedChanged, null) && !ReferenceEquals(nextProps.IsStylusCapturedChanged, null))
			{
				Element.IsStylusCapturedChanged += nextProps.IsStylusCapturedChanged;
			}
			if (!ReferenceEquals(previous?.IsStylusCaptureWithinChanged, null) && ReferenceEquals(nextProps.IsStylusCaptureWithinChanged, null))
			{
				Element.IsStylusCaptureWithinChanged -= nextProps.IsStylusCaptureWithinChanged;
			}
			if (ReferenceEquals(previous?.IsStylusCaptureWithinChanged, null) && !ReferenceEquals(nextProps.IsStylusCaptureWithinChanged, null))
			{
				Element.IsStylusCaptureWithinChanged += nextProps.IsStylusCaptureWithinChanged;
			}
			if (!ReferenceEquals(previous?.IsKeyboardFocusedChanged, null) && ReferenceEquals(nextProps.IsKeyboardFocusedChanged, null))
			{
				Element.IsKeyboardFocusedChanged -= nextProps.IsKeyboardFocusedChanged;
			}
			if (ReferenceEquals(previous?.IsKeyboardFocusedChanged, null) && !ReferenceEquals(nextProps.IsKeyboardFocusedChanged, null))
			{
				Element.IsKeyboardFocusedChanged += nextProps.IsKeyboardFocusedChanged;
			}
			if (!ReferenceEquals(previous?.LayoutUpdated, null) && ReferenceEquals(nextProps.LayoutUpdated, null))
			{
				Element.LayoutUpdated -= nextProps.LayoutUpdated;
			}
			if (ReferenceEquals(previous?.LayoutUpdated, null) && !ReferenceEquals(nextProps.LayoutUpdated, null))
			{
				Element.LayoutUpdated += nextProps.LayoutUpdated;
			}
			if (!ReferenceEquals(previous?.GotFocus, null) && ReferenceEquals(nextProps.GotFocus, null))
			{
				Element.GotFocus -= nextProps.GotFocus;
			}
			if (ReferenceEquals(previous?.GotFocus, null) && !ReferenceEquals(nextProps.GotFocus, null))
			{
				Element.GotFocus += nextProps.GotFocus;
			}
			if (!ReferenceEquals(previous?.LostFocus, null) && ReferenceEquals(nextProps.LostFocus, null))
			{
				Element.LostFocus -= nextProps.LostFocus;
			}
			if (ReferenceEquals(previous?.LostFocus, null) && !ReferenceEquals(nextProps.LostFocus, null))
			{
				Element.LostFocus += nextProps.LostFocus;
			}
			if (!ReferenceEquals(previous?.IsEnabledChanged, null) && ReferenceEquals(nextProps.IsEnabledChanged, null))
			{
				Element.IsEnabledChanged -= nextProps.IsEnabledChanged;
			}
			if (ReferenceEquals(previous?.IsEnabledChanged, null) && !ReferenceEquals(nextProps.IsEnabledChanged, null))
			{
				Element.IsEnabledChanged += nextProps.IsEnabledChanged;
			}
			if (!ReferenceEquals(previous?.IsHitTestVisibleChanged, null) && ReferenceEquals(nextProps.IsHitTestVisibleChanged, null))
			{
				Element.IsHitTestVisibleChanged -= nextProps.IsHitTestVisibleChanged;
			}
			if (ReferenceEquals(previous?.IsHitTestVisibleChanged, null) && !ReferenceEquals(nextProps.IsHitTestVisibleChanged, null))
			{
				Element.IsHitTestVisibleChanged += nextProps.IsHitTestVisibleChanged;
			}
			if (!ReferenceEquals(previous?.IsVisibleChanged, null) && ReferenceEquals(nextProps.IsVisibleChanged, null))
			{
				Element.IsVisibleChanged -= nextProps.IsVisibleChanged;
			}
			if (ReferenceEquals(previous?.IsVisibleChanged, null) && !ReferenceEquals(nextProps.IsVisibleChanged, null))
			{
				Element.IsVisibleChanged += nextProps.IsVisibleChanged;
			}
			if (!ReferenceEquals(previous?.FocusableChanged, null) && ReferenceEquals(nextProps.FocusableChanged, null))
			{
				Element.FocusableChanged -= nextProps.FocusableChanged;
			}
			if (ReferenceEquals(previous?.FocusableChanged, null) && !ReferenceEquals(nextProps.FocusableChanged, null))
			{
				Element.FocusableChanged += nextProps.FocusableChanged;
			}
			if (!ReferenceEquals(previous?.ManipulationStarting, null) && ReferenceEquals(nextProps.ManipulationStarting, null))
			{
				Element.ManipulationStarting -= nextProps.ManipulationStarting;
			}
			if (ReferenceEquals(previous?.ManipulationStarting, null) && !ReferenceEquals(nextProps.ManipulationStarting, null))
			{
				Element.ManipulationStarting += nextProps.ManipulationStarting;
			}
			if (!ReferenceEquals(previous?.ManipulationStarted, null) && ReferenceEquals(nextProps.ManipulationStarted, null))
			{
				Element.ManipulationStarted -= nextProps.ManipulationStarted;
			}
			if (ReferenceEquals(previous?.ManipulationStarted, null) && !ReferenceEquals(nextProps.ManipulationStarted, null))
			{
				Element.ManipulationStarted += nextProps.ManipulationStarted;
			}
			if (!ReferenceEquals(previous?.ManipulationDelta, null) && ReferenceEquals(nextProps.ManipulationDelta, null))
			{
				Element.ManipulationDelta -= nextProps.ManipulationDelta;
			}
			if (ReferenceEquals(previous?.ManipulationDelta, null) && !ReferenceEquals(nextProps.ManipulationDelta, null))
			{
				Element.ManipulationDelta += nextProps.ManipulationDelta;
			}
			if (!ReferenceEquals(previous?.ManipulationInertiaStarting, null) && ReferenceEquals(nextProps.ManipulationInertiaStarting, null))
			{
				Element.ManipulationInertiaStarting -= nextProps.ManipulationInertiaStarting;
			}
			if (ReferenceEquals(previous?.ManipulationInertiaStarting, null) && !ReferenceEquals(nextProps.ManipulationInertiaStarting, null))
			{
				Element.ManipulationInertiaStarting += nextProps.ManipulationInertiaStarting;
			}
			if (!ReferenceEquals(previous?.ManipulationBoundaryFeedback, null) && ReferenceEquals(nextProps.ManipulationBoundaryFeedback, null))
			{
				Element.ManipulationBoundaryFeedback -= nextProps.ManipulationBoundaryFeedback;
			}
			if (ReferenceEquals(previous?.ManipulationBoundaryFeedback, null) && !ReferenceEquals(nextProps.ManipulationBoundaryFeedback, null))
			{
				Element.ManipulationBoundaryFeedback += nextProps.ManipulationBoundaryFeedback;
			}
			if (!ReferenceEquals(previous?.ManipulationCompleted, null) && ReferenceEquals(nextProps.ManipulationCompleted, null))
			{
				Element.ManipulationCompleted -= nextProps.ManipulationCompleted;
			}
			if (ReferenceEquals(previous?.ManipulationCompleted, null) && !ReferenceEquals(nextProps.ManipulationCompleted, null))
			{
				Element.ManipulationCompleted += nextProps.ManipulationCompleted;
			}
		}
	}
}
