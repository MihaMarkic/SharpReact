
namespace SharpReact.Wpf.Components
{
	public  class UIElement<TProps, TElement>: SharpWpfComponent<TProps, object, TElement>
		where TProps : Props.UIElement
		where TElement : System.Windows.UIElement
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.UIElement();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
			if (nextProps.BitmapEffect.HasValue)
			{
				Element.BitmapEffect = nextProps.BitmapEffect.Value.Value;
			}
			if (nextProps.Effect.HasValue)
			{
				Element.Effect = nextProps.Effect.Value.Value;
			}
			if (nextProps.BitmapEffectInput.HasValue)
			{
				Element.BitmapEffectInput = nextProps.BitmapEffectInput.Value.Value;
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
			if (!ReferenceEquals(Props?.PreviewMouseDown, null) && ReferenceEquals(nextProps.PreviewMouseDown, null))
			{
				Element.PreviewMouseDown -= nextProps.PreviewMouseDown;
			}
			if (ReferenceEquals(Props?.PreviewMouseDown, null) && !ReferenceEquals(nextProps.PreviewMouseDown, null))
			{
				Element.PreviewMouseDown += nextProps.PreviewMouseDown;
			}
			if (!ReferenceEquals(Props?.MouseDown, null) && ReferenceEquals(nextProps.MouseDown, null))
			{
				Element.MouseDown -= nextProps.MouseDown;
			}
			if (ReferenceEquals(Props?.MouseDown, null) && !ReferenceEquals(nextProps.MouseDown, null))
			{
				Element.MouseDown += nextProps.MouseDown;
			}
			if (!ReferenceEquals(Props?.PreviewMouseUp, null) && ReferenceEquals(nextProps.PreviewMouseUp, null))
			{
				Element.PreviewMouseUp -= nextProps.PreviewMouseUp;
			}
			if (ReferenceEquals(Props?.PreviewMouseUp, null) && !ReferenceEquals(nextProps.PreviewMouseUp, null))
			{
				Element.PreviewMouseUp += nextProps.PreviewMouseUp;
			}
			if (!ReferenceEquals(Props?.MouseUp, null) && ReferenceEquals(nextProps.MouseUp, null))
			{
				Element.MouseUp -= nextProps.MouseUp;
			}
			if (ReferenceEquals(Props?.MouseUp, null) && !ReferenceEquals(nextProps.MouseUp, null))
			{
				Element.MouseUp += nextProps.MouseUp;
			}
			if (!ReferenceEquals(Props?.PreviewMouseLeftButtonDown, null) && ReferenceEquals(nextProps.PreviewMouseLeftButtonDown, null))
			{
				Element.PreviewMouseLeftButtonDown -= nextProps.PreviewMouseLeftButtonDown;
			}
			if (ReferenceEquals(Props?.PreviewMouseLeftButtonDown, null) && !ReferenceEquals(nextProps.PreviewMouseLeftButtonDown, null))
			{
				Element.PreviewMouseLeftButtonDown += nextProps.PreviewMouseLeftButtonDown;
			}
			if (!ReferenceEquals(Props?.MouseLeftButtonDown, null) && ReferenceEquals(nextProps.MouseLeftButtonDown, null))
			{
				Element.MouseLeftButtonDown -= nextProps.MouseLeftButtonDown;
			}
			if (ReferenceEquals(Props?.MouseLeftButtonDown, null) && !ReferenceEquals(nextProps.MouseLeftButtonDown, null))
			{
				Element.MouseLeftButtonDown += nextProps.MouseLeftButtonDown;
			}
			if (!ReferenceEquals(Props?.PreviewMouseLeftButtonUp, null) && ReferenceEquals(nextProps.PreviewMouseLeftButtonUp, null))
			{
				Element.PreviewMouseLeftButtonUp -= nextProps.PreviewMouseLeftButtonUp;
			}
			if (ReferenceEquals(Props?.PreviewMouseLeftButtonUp, null) && !ReferenceEquals(nextProps.PreviewMouseLeftButtonUp, null))
			{
				Element.PreviewMouseLeftButtonUp += nextProps.PreviewMouseLeftButtonUp;
			}
			if (!ReferenceEquals(Props?.MouseLeftButtonUp, null) && ReferenceEquals(nextProps.MouseLeftButtonUp, null))
			{
				Element.MouseLeftButtonUp -= nextProps.MouseLeftButtonUp;
			}
			if (ReferenceEquals(Props?.MouseLeftButtonUp, null) && !ReferenceEquals(nextProps.MouseLeftButtonUp, null))
			{
				Element.MouseLeftButtonUp += nextProps.MouseLeftButtonUp;
			}
			if (!ReferenceEquals(Props?.PreviewMouseRightButtonDown, null) && ReferenceEquals(nextProps.PreviewMouseRightButtonDown, null))
			{
				Element.PreviewMouseRightButtonDown -= nextProps.PreviewMouseRightButtonDown;
			}
			if (ReferenceEquals(Props?.PreviewMouseRightButtonDown, null) && !ReferenceEquals(nextProps.PreviewMouseRightButtonDown, null))
			{
				Element.PreviewMouseRightButtonDown += nextProps.PreviewMouseRightButtonDown;
			}
			if (!ReferenceEquals(Props?.MouseRightButtonDown, null) && ReferenceEquals(nextProps.MouseRightButtonDown, null))
			{
				Element.MouseRightButtonDown -= nextProps.MouseRightButtonDown;
			}
			if (ReferenceEquals(Props?.MouseRightButtonDown, null) && !ReferenceEquals(nextProps.MouseRightButtonDown, null))
			{
				Element.MouseRightButtonDown += nextProps.MouseRightButtonDown;
			}
			if (!ReferenceEquals(Props?.PreviewMouseRightButtonUp, null) && ReferenceEquals(nextProps.PreviewMouseRightButtonUp, null))
			{
				Element.PreviewMouseRightButtonUp -= nextProps.PreviewMouseRightButtonUp;
			}
			if (ReferenceEquals(Props?.PreviewMouseRightButtonUp, null) && !ReferenceEquals(nextProps.PreviewMouseRightButtonUp, null))
			{
				Element.PreviewMouseRightButtonUp += nextProps.PreviewMouseRightButtonUp;
			}
			if (!ReferenceEquals(Props?.MouseRightButtonUp, null) && ReferenceEquals(nextProps.MouseRightButtonUp, null))
			{
				Element.MouseRightButtonUp -= nextProps.MouseRightButtonUp;
			}
			if (ReferenceEquals(Props?.MouseRightButtonUp, null) && !ReferenceEquals(nextProps.MouseRightButtonUp, null))
			{
				Element.MouseRightButtonUp += nextProps.MouseRightButtonUp;
			}
			if (!ReferenceEquals(Props?.PreviewMouseMove, null) && ReferenceEquals(nextProps.PreviewMouseMove, null))
			{
				Element.PreviewMouseMove -= nextProps.PreviewMouseMove;
			}
			if (ReferenceEquals(Props?.PreviewMouseMove, null) && !ReferenceEquals(nextProps.PreviewMouseMove, null))
			{
				Element.PreviewMouseMove += nextProps.PreviewMouseMove;
			}
			if (!ReferenceEquals(Props?.MouseMove, null) && ReferenceEquals(nextProps.MouseMove, null))
			{
				Element.MouseMove -= nextProps.MouseMove;
			}
			if (ReferenceEquals(Props?.MouseMove, null) && !ReferenceEquals(nextProps.MouseMove, null))
			{
				Element.MouseMove += nextProps.MouseMove;
			}
			if (!ReferenceEquals(Props?.PreviewMouseWheel, null) && ReferenceEquals(nextProps.PreviewMouseWheel, null))
			{
				Element.PreviewMouseWheel -= nextProps.PreviewMouseWheel;
			}
			if (ReferenceEquals(Props?.PreviewMouseWheel, null) && !ReferenceEquals(nextProps.PreviewMouseWheel, null))
			{
				Element.PreviewMouseWheel += nextProps.PreviewMouseWheel;
			}
			if (!ReferenceEquals(Props?.MouseWheel, null) && ReferenceEquals(nextProps.MouseWheel, null))
			{
				Element.MouseWheel -= nextProps.MouseWheel;
			}
			if (ReferenceEquals(Props?.MouseWheel, null) && !ReferenceEquals(nextProps.MouseWheel, null))
			{
				Element.MouseWheel += nextProps.MouseWheel;
			}
			if (!ReferenceEquals(Props?.MouseEnter, null) && ReferenceEquals(nextProps.MouseEnter, null))
			{
				Element.MouseEnter -= nextProps.MouseEnter;
			}
			if (ReferenceEquals(Props?.MouseEnter, null) && !ReferenceEquals(nextProps.MouseEnter, null))
			{
				Element.MouseEnter += nextProps.MouseEnter;
			}
			if (!ReferenceEquals(Props?.MouseLeave, null) && ReferenceEquals(nextProps.MouseLeave, null))
			{
				Element.MouseLeave -= nextProps.MouseLeave;
			}
			if (ReferenceEquals(Props?.MouseLeave, null) && !ReferenceEquals(nextProps.MouseLeave, null))
			{
				Element.MouseLeave += nextProps.MouseLeave;
			}
			if (!ReferenceEquals(Props?.GotMouseCapture, null) && ReferenceEquals(nextProps.GotMouseCapture, null))
			{
				Element.GotMouseCapture -= nextProps.GotMouseCapture;
			}
			if (ReferenceEquals(Props?.GotMouseCapture, null) && !ReferenceEquals(nextProps.GotMouseCapture, null))
			{
				Element.GotMouseCapture += nextProps.GotMouseCapture;
			}
			if (!ReferenceEquals(Props?.LostMouseCapture, null) && ReferenceEquals(nextProps.LostMouseCapture, null))
			{
				Element.LostMouseCapture -= nextProps.LostMouseCapture;
			}
			if (ReferenceEquals(Props?.LostMouseCapture, null) && !ReferenceEquals(nextProps.LostMouseCapture, null))
			{
				Element.LostMouseCapture += nextProps.LostMouseCapture;
			}
			if (!ReferenceEquals(Props?.QueryCursor, null) && ReferenceEquals(nextProps.QueryCursor, null))
			{
				Element.QueryCursor -= nextProps.QueryCursor;
			}
			if (ReferenceEquals(Props?.QueryCursor, null) && !ReferenceEquals(nextProps.QueryCursor, null))
			{
				Element.QueryCursor += nextProps.QueryCursor;
			}
			if (!ReferenceEquals(Props?.PreviewStylusDown, null) && ReferenceEquals(nextProps.PreviewStylusDown, null))
			{
				Element.PreviewStylusDown -= nextProps.PreviewStylusDown;
			}
			if (ReferenceEquals(Props?.PreviewStylusDown, null) && !ReferenceEquals(nextProps.PreviewStylusDown, null))
			{
				Element.PreviewStylusDown += nextProps.PreviewStylusDown;
			}
			if (!ReferenceEquals(Props?.StylusDown, null) && ReferenceEquals(nextProps.StylusDown, null))
			{
				Element.StylusDown -= nextProps.StylusDown;
			}
			if (ReferenceEquals(Props?.StylusDown, null) && !ReferenceEquals(nextProps.StylusDown, null))
			{
				Element.StylusDown += nextProps.StylusDown;
			}
			if (!ReferenceEquals(Props?.PreviewStylusUp, null) && ReferenceEquals(nextProps.PreviewStylusUp, null))
			{
				Element.PreviewStylusUp -= nextProps.PreviewStylusUp;
			}
			if (ReferenceEquals(Props?.PreviewStylusUp, null) && !ReferenceEquals(nextProps.PreviewStylusUp, null))
			{
				Element.PreviewStylusUp += nextProps.PreviewStylusUp;
			}
			if (!ReferenceEquals(Props?.StylusUp, null) && ReferenceEquals(nextProps.StylusUp, null))
			{
				Element.StylusUp -= nextProps.StylusUp;
			}
			if (ReferenceEquals(Props?.StylusUp, null) && !ReferenceEquals(nextProps.StylusUp, null))
			{
				Element.StylusUp += nextProps.StylusUp;
			}
			if (!ReferenceEquals(Props?.PreviewStylusMove, null) && ReferenceEquals(nextProps.PreviewStylusMove, null))
			{
				Element.PreviewStylusMove -= nextProps.PreviewStylusMove;
			}
			if (ReferenceEquals(Props?.PreviewStylusMove, null) && !ReferenceEquals(nextProps.PreviewStylusMove, null))
			{
				Element.PreviewStylusMove += nextProps.PreviewStylusMove;
			}
			if (!ReferenceEquals(Props?.StylusMove, null) && ReferenceEquals(nextProps.StylusMove, null))
			{
				Element.StylusMove -= nextProps.StylusMove;
			}
			if (ReferenceEquals(Props?.StylusMove, null) && !ReferenceEquals(nextProps.StylusMove, null))
			{
				Element.StylusMove += nextProps.StylusMove;
			}
			if (!ReferenceEquals(Props?.PreviewStylusInAirMove, null) && ReferenceEquals(nextProps.PreviewStylusInAirMove, null))
			{
				Element.PreviewStylusInAirMove -= nextProps.PreviewStylusInAirMove;
			}
			if (ReferenceEquals(Props?.PreviewStylusInAirMove, null) && !ReferenceEquals(nextProps.PreviewStylusInAirMove, null))
			{
				Element.PreviewStylusInAirMove += nextProps.PreviewStylusInAirMove;
			}
			if (!ReferenceEquals(Props?.StylusInAirMove, null) && ReferenceEquals(nextProps.StylusInAirMove, null))
			{
				Element.StylusInAirMove -= nextProps.StylusInAirMove;
			}
			if (ReferenceEquals(Props?.StylusInAirMove, null) && !ReferenceEquals(nextProps.StylusInAirMove, null))
			{
				Element.StylusInAirMove += nextProps.StylusInAirMove;
			}
			if (!ReferenceEquals(Props?.StylusEnter, null) && ReferenceEquals(nextProps.StylusEnter, null))
			{
				Element.StylusEnter -= nextProps.StylusEnter;
			}
			if (ReferenceEquals(Props?.StylusEnter, null) && !ReferenceEquals(nextProps.StylusEnter, null))
			{
				Element.StylusEnter += nextProps.StylusEnter;
			}
			if (!ReferenceEquals(Props?.StylusLeave, null) && ReferenceEquals(nextProps.StylusLeave, null))
			{
				Element.StylusLeave -= nextProps.StylusLeave;
			}
			if (ReferenceEquals(Props?.StylusLeave, null) && !ReferenceEquals(nextProps.StylusLeave, null))
			{
				Element.StylusLeave += nextProps.StylusLeave;
			}
			if (!ReferenceEquals(Props?.PreviewStylusInRange, null) && ReferenceEquals(nextProps.PreviewStylusInRange, null))
			{
				Element.PreviewStylusInRange -= nextProps.PreviewStylusInRange;
			}
			if (ReferenceEquals(Props?.PreviewStylusInRange, null) && !ReferenceEquals(nextProps.PreviewStylusInRange, null))
			{
				Element.PreviewStylusInRange += nextProps.PreviewStylusInRange;
			}
			if (!ReferenceEquals(Props?.StylusInRange, null) && ReferenceEquals(nextProps.StylusInRange, null))
			{
				Element.StylusInRange -= nextProps.StylusInRange;
			}
			if (ReferenceEquals(Props?.StylusInRange, null) && !ReferenceEquals(nextProps.StylusInRange, null))
			{
				Element.StylusInRange += nextProps.StylusInRange;
			}
			if (!ReferenceEquals(Props?.PreviewStylusOutOfRange, null) && ReferenceEquals(nextProps.PreviewStylusOutOfRange, null))
			{
				Element.PreviewStylusOutOfRange -= nextProps.PreviewStylusOutOfRange;
			}
			if (ReferenceEquals(Props?.PreviewStylusOutOfRange, null) && !ReferenceEquals(nextProps.PreviewStylusOutOfRange, null))
			{
				Element.PreviewStylusOutOfRange += nextProps.PreviewStylusOutOfRange;
			}
			if (!ReferenceEquals(Props?.StylusOutOfRange, null) && ReferenceEquals(nextProps.StylusOutOfRange, null))
			{
				Element.StylusOutOfRange -= nextProps.StylusOutOfRange;
			}
			if (ReferenceEquals(Props?.StylusOutOfRange, null) && !ReferenceEquals(nextProps.StylusOutOfRange, null))
			{
				Element.StylusOutOfRange += nextProps.StylusOutOfRange;
			}
			if (!ReferenceEquals(Props?.PreviewStylusSystemGesture, null) && ReferenceEquals(nextProps.PreviewStylusSystemGesture, null))
			{
				Element.PreviewStylusSystemGesture -= nextProps.PreviewStylusSystemGesture;
			}
			if (ReferenceEquals(Props?.PreviewStylusSystemGesture, null) && !ReferenceEquals(nextProps.PreviewStylusSystemGesture, null))
			{
				Element.PreviewStylusSystemGesture += nextProps.PreviewStylusSystemGesture;
			}
			if (!ReferenceEquals(Props?.StylusSystemGesture, null) && ReferenceEquals(nextProps.StylusSystemGesture, null))
			{
				Element.StylusSystemGesture -= nextProps.StylusSystemGesture;
			}
			if (ReferenceEquals(Props?.StylusSystemGesture, null) && !ReferenceEquals(nextProps.StylusSystemGesture, null))
			{
				Element.StylusSystemGesture += nextProps.StylusSystemGesture;
			}
			if (!ReferenceEquals(Props?.GotStylusCapture, null) && ReferenceEquals(nextProps.GotStylusCapture, null))
			{
				Element.GotStylusCapture -= nextProps.GotStylusCapture;
			}
			if (ReferenceEquals(Props?.GotStylusCapture, null) && !ReferenceEquals(nextProps.GotStylusCapture, null))
			{
				Element.GotStylusCapture += nextProps.GotStylusCapture;
			}
			if (!ReferenceEquals(Props?.LostStylusCapture, null) && ReferenceEquals(nextProps.LostStylusCapture, null))
			{
				Element.LostStylusCapture -= nextProps.LostStylusCapture;
			}
			if (ReferenceEquals(Props?.LostStylusCapture, null) && !ReferenceEquals(nextProps.LostStylusCapture, null))
			{
				Element.LostStylusCapture += nextProps.LostStylusCapture;
			}
			if (!ReferenceEquals(Props?.StylusButtonDown, null) && ReferenceEquals(nextProps.StylusButtonDown, null))
			{
				Element.StylusButtonDown -= nextProps.StylusButtonDown;
			}
			if (ReferenceEquals(Props?.StylusButtonDown, null) && !ReferenceEquals(nextProps.StylusButtonDown, null))
			{
				Element.StylusButtonDown += nextProps.StylusButtonDown;
			}
			if (!ReferenceEquals(Props?.StylusButtonUp, null) && ReferenceEquals(nextProps.StylusButtonUp, null))
			{
				Element.StylusButtonUp -= nextProps.StylusButtonUp;
			}
			if (ReferenceEquals(Props?.StylusButtonUp, null) && !ReferenceEquals(nextProps.StylusButtonUp, null))
			{
				Element.StylusButtonUp += nextProps.StylusButtonUp;
			}
			if (!ReferenceEquals(Props?.PreviewStylusButtonDown, null) && ReferenceEquals(nextProps.PreviewStylusButtonDown, null))
			{
				Element.PreviewStylusButtonDown -= nextProps.PreviewStylusButtonDown;
			}
			if (ReferenceEquals(Props?.PreviewStylusButtonDown, null) && !ReferenceEquals(nextProps.PreviewStylusButtonDown, null))
			{
				Element.PreviewStylusButtonDown += nextProps.PreviewStylusButtonDown;
			}
			if (!ReferenceEquals(Props?.PreviewStylusButtonUp, null) && ReferenceEquals(nextProps.PreviewStylusButtonUp, null))
			{
				Element.PreviewStylusButtonUp -= nextProps.PreviewStylusButtonUp;
			}
			if (ReferenceEquals(Props?.PreviewStylusButtonUp, null) && !ReferenceEquals(nextProps.PreviewStylusButtonUp, null))
			{
				Element.PreviewStylusButtonUp += nextProps.PreviewStylusButtonUp;
			}
			if (!ReferenceEquals(Props?.PreviewKeyDown, null) && ReferenceEquals(nextProps.PreviewKeyDown, null))
			{
				Element.PreviewKeyDown -= nextProps.PreviewKeyDown;
			}
			if (ReferenceEquals(Props?.PreviewKeyDown, null) && !ReferenceEquals(nextProps.PreviewKeyDown, null))
			{
				Element.PreviewKeyDown += nextProps.PreviewKeyDown;
			}
			if (!ReferenceEquals(Props?.KeyDown, null) && ReferenceEquals(nextProps.KeyDown, null))
			{
				Element.KeyDown -= nextProps.KeyDown;
			}
			if (ReferenceEquals(Props?.KeyDown, null) && !ReferenceEquals(nextProps.KeyDown, null))
			{
				Element.KeyDown += nextProps.KeyDown;
			}
			if (!ReferenceEquals(Props?.PreviewKeyUp, null) && ReferenceEquals(nextProps.PreviewKeyUp, null))
			{
				Element.PreviewKeyUp -= nextProps.PreviewKeyUp;
			}
			if (ReferenceEquals(Props?.PreviewKeyUp, null) && !ReferenceEquals(nextProps.PreviewKeyUp, null))
			{
				Element.PreviewKeyUp += nextProps.PreviewKeyUp;
			}
			if (!ReferenceEquals(Props?.KeyUp, null) && ReferenceEquals(nextProps.KeyUp, null))
			{
				Element.KeyUp -= nextProps.KeyUp;
			}
			if (ReferenceEquals(Props?.KeyUp, null) && !ReferenceEquals(nextProps.KeyUp, null))
			{
				Element.KeyUp += nextProps.KeyUp;
			}
			if (!ReferenceEquals(Props?.PreviewGotKeyboardFocus, null) && ReferenceEquals(nextProps.PreviewGotKeyboardFocus, null))
			{
				Element.PreviewGotKeyboardFocus -= nextProps.PreviewGotKeyboardFocus;
			}
			if (ReferenceEquals(Props?.PreviewGotKeyboardFocus, null) && !ReferenceEquals(nextProps.PreviewGotKeyboardFocus, null))
			{
				Element.PreviewGotKeyboardFocus += nextProps.PreviewGotKeyboardFocus;
			}
			if (!ReferenceEquals(Props?.GotKeyboardFocus, null) && ReferenceEquals(nextProps.GotKeyboardFocus, null))
			{
				Element.GotKeyboardFocus -= nextProps.GotKeyboardFocus;
			}
			if (ReferenceEquals(Props?.GotKeyboardFocus, null) && !ReferenceEquals(nextProps.GotKeyboardFocus, null))
			{
				Element.GotKeyboardFocus += nextProps.GotKeyboardFocus;
			}
			if (!ReferenceEquals(Props?.PreviewLostKeyboardFocus, null) && ReferenceEquals(nextProps.PreviewLostKeyboardFocus, null))
			{
				Element.PreviewLostKeyboardFocus -= nextProps.PreviewLostKeyboardFocus;
			}
			if (ReferenceEquals(Props?.PreviewLostKeyboardFocus, null) && !ReferenceEquals(nextProps.PreviewLostKeyboardFocus, null))
			{
				Element.PreviewLostKeyboardFocus += nextProps.PreviewLostKeyboardFocus;
			}
			if (!ReferenceEquals(Props?.LostKeyboardFocus, null) && ReferenceEquals(nextProps.LostKeyboardFocus, null))
			{
				Element.LostKeyboardFocus -= nextProps.LostKeyboardFocus;
			}
			if (ReferenceEquals(Props?.LostKeyboardFocus, null) && !ReferenceEquals(nextProps.LostKeyboardFocus, null))
			{
				Element.LostKeyboardFocus += nextProps.LostKeyboardFocus;
			}
			if (!ReferenceEquals(Props?.PreviewTextInput, null) && ReferenceEquals(nextProps.PreviewTextInput, null))
			{
				Element.PreviewTextInput -= nextProps.PreviewTextInput;
			}
			if (ReferenceEquals(Props?.PreviewTextInput, null) && !ReferenceEquals(nextProps.PreviewTextInput, null))
			{
				Element.PreviewTextInput += nextProps.PreviewTextInput;
			}
			if (!ReferenceEquals(Props?.TextInput, null) && ReferenceEquals(nextProps.TextInput, null))
			{
				Element.TextInput -= nextProps.TextInput;
			}
			if (ReferenceEquals(Props?.TextInput, null) && !ReferenceEquals(nextProps.TextInput, null))
			{
				Element.TextInput += nextProps.TextInput;
			}
			if (!ReferenceEquals(Props?.PreviewQueryContinueDrag, null) && ReferenceEquals(nextProps.PreviewQueryContinueDrag, null))
			{
				Element.PreviewQueryContinueDrag -= nextProps.PreviewQueryContinueDrag;
			}
			if (ReferenceEquals(Props?.PreviewQueryContinueDrag, null) && !ReferenceEquals(nextProps.PreviewQueryContinueDrag, null))
			{
				Element.PreviewQueryContinueDrag += nextProps.PreviewQueryContinueDrag;
			}
			if (!ReferenceEquals(Props?.QueryContinueDrag, null) && ReferenceEquals(nextProps.QueryContinueDrag, null))
			{
				Element.QueryContinueDrag -= nextProps.QueryContinueDrag;
			}
			if (ReferenceEquals(Props?.QueryContinueDrag, null) && !ReferenceEquals(nextProps.QueryContinueDrag, null))
			{
				Element.QueryContinueDrag += nextProps.QueryContinueDrag;
			}
			if (!ReferenceEquals(Props?.PreviewGiveFeedback, null) && ReferenceEquals(nextProps.PreviewGiveFeedback, null))
			{
				Element.PreviewGiveFeedback -= nextProps.PreviewGiveFeedback;
			}
			if (ReferenceEquals(Props?.PreviewGiveFeedback, null) && !ReferenceEquals(nextProps.PreviewGiveFeedback, null))
			{
				Element.PreviewGiveFeedback += nextProps.PreviewGiveFeedback;
			}
			if (!ReferenceEquals(Props?.GiveFeedback, null) && ReferenceEquals(nextProps.GiveFeedback, null))
			{
				Element.GiveFeedback -= nextProps.GiveFeedback;
			}
			if (ReferenceEquals(Props?.GiveFeedback, null) && !ReferenceEquals(nextProps.GiveFeedback, null))
			{
				Element.GiveFeedback += nextProps.GiveFeedback;
			}
			if (!ReferenceEquals(Props?.PreviewDragEnter, null) && ReferenceEquals(nextProps.PreviewDragEnter, null))
			{
				Element.PreviewDragEnter -= nextProps.PreviewDragEnter;
			}
			if (ReferenceEquals(Props?.PreviewDragEnter, null) && !ReferenceEquals(nextProps.PreviewDragEnter, null))
			{
				Element.PreviewDragEnter += nextProps.PreviewDragEnter;
			}
			if (!ReferenceEquals(Props?.DragEnter, null) && ReferenceEquals(nextProps.DragEnter, null))
			{
				Element.DragEnter -= nextProps.DragEnter;
			}
			if (ReferenceEquals(Props?.DragEnter, null) && !ReferenceEquals(nextProps.DragEnter, null))
			{
				Element.DragEnter += nextProps.DragEnter;
			}
			if (!ReferenceEquals(Props?.PreviewDragOver, null) && ReferenceEquals(nextProps.PreviewDragOver, null))
			{
				Element.PreviewDragOver -= nextProps.PreviewDragOver;
			}
			if (ReferenceEquals(Props?.PreviewDragOver, null) && !ReferenceEquals(nextProps.PreviewDragOver, null))
			{
				Element.PreviewDragOver += nextProps.PreviewDragOver;
			}
			if (!ReferenceEquals(Props?.DragOver, null) && ReferenceEquals(nextProps.DragOver, null))
			{
				Element.DragOver -= nextProps.DragOver;
			}
			if (ReferenceEquals(Props?.DragOver, null) && !ReferenceEquals(nextProps.DragOver, null))
			{
				Element.DragOver += nextProps.DragOver;
			}
			if (!ReferenceEquals(Props?.PreviewDragLeave, null) && ReferenceEquals(nextProps.PreviewDragLeave, null))
			{
				Element.PreviewDragLeave -= nextProps.PreviewDragLeave;
			}
			if (ReferenceEquals(Props?.PreviewDragLeave, null) && !ReferenceEquals(nextProps.PreviewDragLeave, null))
			{
				Element.PreviewDragLeave += nextProps.PreviewDragLeave;
			}
			if (!ReferenceEquals(Props?.DragLeave, null) && ReferenceEquals(nextProps.DragLeave, null))
			{
				Element.DragLeave -= nextProps.DragLeave;
			}
			if (ReferenceEquals(Props?.DragLeave, null) && !ReferenceEquals(nextProps.DragLeave, null))
			{
				Element.DragLeave += nextProps.DragLeave;
			}
			if (!ReferenceEquals(Props?.PreviewDrop, null) && ReferenceEquals(nextProps.PreviewDrop, null))
			{
				Element.PreviewDrop -= nextProps.PreviewDrop;
			}
			if (ReferenceEquals(Props?.PreviewDrop, null) && !ReferenceEquals(nextProps.PreviewDrop, null))
			{
				Element.PreviewDrop += nextProps.PreviewDrop;
			}
			if (!ReferenceEquals(Props?.Drop, null) && ReferenceEquals(nextProps.Drop, null))
			{
				Element.Drop -= nextProps.Drop;
			}
			if (ReferenceEquals(Props?.Drop, null) && !ReferenceEquals(nextProps.Drop, null))
			{
				Element.Drop += nextProps.Drop;
			}
			if (!ReferenceEquals(Props?.PreviewTouchDown, null) && ReferenceEquals(nextProps.PreviewTouchDown, null))
			{
				Element.PreviewTouchDown -= nextProps.PreviewTouchDown;
			}
			if (ReferenceEquals(Props?.PreviewTouchDown, null) && !ReferenceEquals(nextProps.PreviewTouchDown, null))
			{
				Element.PreviewTouchDown += nextProps.PreviewTouchDown;
			}
			if (!ReferenceEquals(Props?.TouchDown, null) && ReferenceEquals(nextProps.TouchDown, null))
			{
				Element.TouchDown -= nextProps.TouchDown;
			}
			if (ReferenceEquals(Props?.TouchDown, null) && !ReferenceEquals(nextProps.TouchDown, null))
			{
				Element.TouchDown += nextProps.TouchDown;
			}
			if (!ReferenceEquals(Props?.PreviewTouchMove, null) && ReferenceEquals(nextProps.PreviewTouchMove, null))
			{
				Element.PreviewTouchMove -= nextProps.PreviewTouchMove;
			}
			if (ReferenceEquals(Props?.PreviewTouchMove, null) && !ReferenceEquals(nextProps.PreviewTouchMove, null))
			{
				Element.PreviewTouchMove += nextProps.PreviewTouchMove;
			}
			if (!ReferenceEquals(Props?.TouchMove, null) && ReferenceEquals(nextProps.TouchMove, null))
			{
				Element.TouchMove -= nextProps.TouchMove;
			}
			if (ReferenceEquals(Props?.TouchMove, null) && !ReferenceEquals(nextProps.TouchMove, null))
			{
				Element.TouchMove += nextProps.TouchMove;
			}
			if (!ReferenceEquals(Props?.PreviewTouchUp, null) && ReferenceEquals(nextProps.PreviewTouchUp, null))
			{
				Element.PreviewTouchUp -= nextProps.PreviewTouchUp;
			}
			if (ReferenceEquals(Props?.PreviewTouchUp, null) && !ReferenceEquals(nextProps.PreviewTouchUp, null))
			{
				Element.PreviewTouchUp += nextProps.PreviewTouchUp;
			}
			if (!ReferenceEquals(Props?.TouchUp, null) && ReferenceEquals(nextProps.TouchUp, null))
			{
				Element.TouchUp -= nextProps.TouchUp;
			}
			if (ReferenceEquals(Props?.TouchUp, null) && !ReferenceEquals(nextProps.TouchUp, null))
			{
				Element.TouchUp += nextProps.TouchUp;
			}
			if (!ReferenceEquals(Props?.GotTouchCapture, null) && ReferenceEquals(nextProps.GotTouchCapture, null))
			{
				Element.GotTouchCapture -= nextProps.GotTouchCapture;
			}
			if (ReferenceEquals(Props?.GotTouchCapture, null) && !ReferenceEquals(nextProps.GotTouchCapture, null))
			{
				Element.GotTouchCapture += nextProps.GotTouchCapture;
			}
			if (!ReferenceEquals(Props?.LostTouchCapture, null) && ReferenceEquals(nextProps.LostTouchCapture, null))
			{
				Element.LostTouchCapture -= nextProps.LostTouchCapture;
			}
			if (ReferenceEquals(Props?.LostTouchCapture, null) && !ReferenceEquals(nextProps.LostTouchCapture, null))
			{
				Element.LostTouchCapture += nextProps.LostTouchCapture;
			}
			if (!ReferenceEquals(Props?.TouchEnter, null) && ReferenceEquals(nextProps.TouchEnter, null))
			{
				Element.TouchEnter -= nextProps.TouchEnter;
			}
			if (ReferenceEquals(Props?.TouchEnter, null) && !ReferenceEquals(nextProps.TouchEnter, null))
			{
				Element.TouchEnter += nextProps.TouchEnter;
			}
			if (!ReferenceEquals(Props?.TouchLeave, null) && ReferenceEquals(nextProps.TouchLeave, null))
			{
				Element.TouchLeave -= nextProps.TouchLeave;
			}
			if (ReferenceEquals(Props?.TouchLeave, null) && !ReferenceEquals(nextProps.TouchLeave, null))
			{
				Element.TouchLeave += nextProps.TouchLeave;
			}
			if (!ReferenceEquals(Props?.IsMouseDirectlyOverChanged, null) && ReferenceEquals(nextProps.IsMouseDirectlyOverChanged, null))
			{
				Element.IsMouseDirectlyOverChanged -= nextProps.IsMouseDirectlyOverChanged;
			}
			if (ReferenceEquals(Props?.IsMouseDirectlyOverChanged, null) && !ReferenceEquals(nextProps.IsMouseDirectlyOverChanged, null))
			{
				Element.IsMouseDirectlyOverChanged += nextProps.IsMouseDirectlyOverChanged;
			}
			if (!ReferenceEquals(Props?.IsKeyboardFocusWithinChanged, null) && ReferenceEquals(nextProps.IsKeyboardFocusWithinChanged, null))
			{
				Element.IsKeyboardFocusWithinChanged -= nextProps.IsKeyboardFocusWithinChanged;
			}
			if (ReferenceEquals(Props?.IsKeyboardFocusWithinChanged, null) && !ReferenceEquals(nextProps.IsKeyboardFocusWithinChanged, null))
			{
				Element.IsKeyboardFocusWithinChanged += nextProps.IsKeyboardFocusWithinChanged;
			}
			if (!ReferenceEquals(Props?.IsMouseCapturedChanged, null) && ReferenceEquals(nextProps.IsMouseCapturedChanged, null))
			{
				Element.IsMouseCapturedChanged -= nextProps.IsMouseCapturedChanged;
			}
			if (ReferenceEquals(Props?.IsMouseCapturedChanged, null) && !ReferenceEquals(nextProps.IsMouseCapturedChanged, null))
			{
				Element.IsMouseCapturedChanged += nextProps.IsMouseCapturedChanged;
			}
			if (!ReferenceEquals(Props?.IsMouseCaptureWithinChanged, null) && ReferenceEquals(nextProps.IsMouseCaptureWithinChanged, null))
			{
				Element.IsMouseCaptureWithinChanged -= nextProps.IsMouseCaptureWithinChanged;
			}
			if (ReferenceEquals(Props?.IsMouseCaptureWithinChanged, null) && !ReferenceEquals(nextProps.IsMouseCaptureWithinChanged, null))
			{
				Element.IsMouseCaptureWithinChanged += nextProps.IsMouseCaptureWithinChanged;
			}
			if (!ReferenceEquals(Props?.IsStylusDirectlyOverChanged, null) && ReferenceEquals(nextProps.IsStylusDirectlyOverChanged, null))
			{
				Element.IsStylusDirectlyOverChanged -= nextProps.IsStylusDirectlyOverChanged;
			}
			if (ReferenceEquals(Props?.IsStylusDirectlyOverChanged, null) && !ReferenceEquals(nextProps.IsStylusDirectlyOverChanged, null))
			{
				Element.IsStylusDirectlyOverChanged += nextProps.IsStylusDirectlyOverChanged;
			}
			if (!ReferenceEquals(Props?.IsStylusCapturedChanged, null) && ReferenceEquals(nextProps.IsStylusCapturedChanged, null))
			{
				Element.IsStylusCapturedChanged -= nextProps.IsStylusCapturedChanged;
			}
			if (ReferenceEquals(Props?.IsStylusCapturedChanged, null) && !ReferenceEquals(nextProps.IsStylusCapturedChanged, null))
			{
				Element.IsStylusCapturedChanged += nextProps.IsStylusCapturedChanged;
			}
			if (!ReferenceEquals(Props?.IsStylusCaptureWithinChanged, null) && ReferenceEquals(nextProps.IsStylusCaptureWithinChanged, null))
			{
				Element.IsStylusCaptureWithinChanged -= nextProps.IsStylusCaptureWithinChanged;
			}
			if (ReferenceEquals(Props?.IsStylusCaptureWithinChanged, null) && !ReferenceEquals(nextProps.IsStylusCaptureWithinChanged, null))
			{
				Element.IsStylusCaptureWithinChanged += nextProps.IsStylusCaptureWithinChanged;
			}
			if (!ReferenceEquals(Props?.IsKeyboardFocusedChanged, null) && ReferenceEquals(nextProps.IsKeyboardFocusedChanged, null))
			{
				Element.IsKeyboardFocusedChanged -= nextProps.IsKeyboardFocusedChanged;
			}
			if (ReferenceEquals(Props?.IsKeyboardFocusedChanged, null) && !ReferenceEquals(nextProps.IsKeyboardFocusedChanged, null))
			{
				Element.IsKeyboardFocusedChanged += nextProps.IsKeyboardFocusedChanged;
			}
			if (!ReferenceEquals(Props?.LayoutUpdated, null) && ReferenceEquals(nextProps.LayoutUpdated, null))
			{
				Element.LayoutUpdated -= nextProps.LayoutUpdated;
			}
			if (ReferenceEquals(Props?.LayoutUpdated, null) && !ReferenceEquals(nextProps.LayoutUpdated, null))
			{
				Element.LayoutUpdated += nextProps.LayoutUpdated;
			}
			if (!ReferenceEquals(Props?.GotFocus, null) && ReferenceEquals(nextProps.GotFocus, null))
			{
				Element.GotFocus -= nextProps.GotFocus;
			}
			if (ReferenceEquals(Props?.GotFocus, null) && !ReferenceEquals(nextProps.GotFocus, null))
			{
				Element.GotFocus += nextProps.GotFocus;
			}
			if (!ReferenceEquals(Props?.LostFocus, null) && ReferenceEquals(nextProps.LostFocus, null))
			{
				Element.LostFocus -= nextProps.LostFocus;
			}
			if (ReferenceEquals(Props?.LostFocus, null) && !ReferenceEquals(nextProps.LostFocus, null))
			{
				Element.LostFocus += nextProps.LostFocus;
			}
			if (!ReferenceEquals(Props?.IsEnabledChanged, null) && ReferenceEquals(nextProps.IsEnabledChanged, null))
			{
				Element.IsEnabledChanged -= nextProps.IsEnabledChanged;
			}
			if (ReferenceEquals(Props?.IsEnabledChanged, null) && !ReferenceEquals(nextProps.IsEnabledChanged, null))
			{
				Element.IsEnabledChanged += nextProps.IsEnabledChanged;
			}
			if (!ReferenceEquals(Props?.IsHitTestVisibleChanged, null) && ReferenceEquals(nextProps.IsHitTestVisibleChanged, null))
			{
				Element.IsHitTestVisibleChanged -= nextProps.IsHitTestVisibleChanged;
			}
			if (ReferenceEquals(Props?.IsHitTestVisibleChanged, null) && !ReferenceEquals(nextProps.IsHitTestVisibleChanged, null))
			{
				Element.IsHitTestVisibleChanged += nextProps.IsHitTestVisibleChanged;
			}
			if (!ReferenceEquals(Props?.IsVisibleChanged, null) && ReferenceEquals(nextProps.IsVisibleChanged, null))
			{
				Element.IsVisibleChanged -= nextProps.IsVisibleChanged;
			}
			if (ReferenceEquals(Props?.IsVisibleChanged, null) && !ReferenceEquals(nextProps.IsVisibleChanged, null))
			{
				Element.IsVisibleChanged += nextProps.IsVisibleChanged;
			}
			if (!ReferenceEquals(Props?.FocusableChanged, null) && ReferenceEquals(nextProps.FocusableChanged, null))
			{
				Element.FocusableChanged -= nextProps.FocusableChanged;
			}
			if (ReferenceEquals(Props?.FocusableChanged, null) && !ReferenceEquals(nextProps.FocusableChanged, null))
			{
				Element.FocusableChanged += nextProps.FocusableChanged;
			}
			if (!ReferenceEquals(Props?.ManipulationStarting, null) && ReferenceEquals(nextProps.ManipulationStarting, null))
			{
				Element.ManipulationStarting -= nextProps.ManipulationStarting;
			}
			if (ReferenceEquals(Props?.ManipulationStarting, null) && !ReferenceEquals(nextProps.ManipulationStarting, null))
			{
				Element.ManipulationStarting += nextProps.ManipulationStarting;
			}
			if (!ReferenceEquals(Props?.ManipulationStarted, null) && ReferenceEquals(nextProps.ManipulationStarted, null))
			{
				Element.ManipulationStarted -= nextProps.ManipulationStarted;
			}
			if (ReferenceEquals(Props?.ManipulationStarted, null) && !ReferenceEquals(nextProps.ManipulationStarted, null))
			{
				Element.ManipulationStarted += nextProps.ManipulationStarted;
			}
			if (!ReferenceEquals(Props?.ManipulationDelta, null) && ReferenceEquals(nextProps.ManipulationDelta, null))
			{
				Element.ManipulationDelta -= nextProps.ManipulationDelta;
			}
			if (ReferenceEquals(Props?.ManipulationDelta, null) && !ReferenceEquals(nextProps.ManipulationDelta, null))
			{
				Element.ManipulationDelta += nextProps.ManipulationDelta;
			}
			if (!ReferenceEquals(Props?.ManipulationInertiaStarting, null) && ReferenceEquals(nextProps.ManipulationInertiaStarting, null))
			{
				Element.ManipulationInertiaStarting -= nextProps.ManipulationInertiaStarting;
			}
			if (ReferenceEquals(Props?.ManipulationInertiaStarting, null) && !ReferenceEquals(nextProps.ManipulationInertiaStarting, null))
			{
				Element.ManipulationInertiaStarting += nextProps.ManipulationInertiaStarting;
			}
			if (!ReferenceEquals(Props?.ManipulationBoundaryFeedback, null) && ReferenceEquals(nextProps.ManipulationBoundaryFeedback, null))
			{
				Element.ManipulationBoundaryFeedback -= nextProps.ManipulationBoundaryFeedback;
			}
			if (ReferenceEquals(Props?.ManipulationBoundaryFeedback, null) && !ReferenceEquals(nextProps.ManipulationBoundaryFeedback, null))
			{
				Element.ManipulationBoundaryFeedback += nextProps.ManipulationBoundaryFeedback;
			}
			if (!ReferenceEquals(Props?.ManipulationCompleted, null) && ReferenceEquals(nextProps.ManipulationCompleted, null))
			{
				Element.ManipulationCompleted -= nextProps.ManipulationCompleted;
			}
			if (ReferenceEquals(Props?.ManipulationCompleted, null) && !ReferenceEquals(nextProps.ManipulationCompleted, null))
			{
				Element.ManipulationCompleted += nextProps.ManipulationCompleted;
			}
		}
	}
}
