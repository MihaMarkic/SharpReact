using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class View<TProps, TElement>: SharpAndroidComponent<TProps, object, TElement>
		where TProps : Props.View
		where TElement : global::Android.Views.View
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.AccessibilityLiveRegion.HasValue)
			{
				Element.AccessibilityLiveRegion = nextProps.AccessibilityLiveRegion.Value.Value;
			}
			if (nextProps.AccessibilityTraversalAfter.HasValue)
			{
				Element.AccessibilityTraversalAfter = nextProps.AccessibilityTraversalAfter.Value.Value;
			}
			if (nextProps.AccessibilityTraversalBefore.HasValue)
			{
				Element.AccessibilityTraversalBefore = nextProps.AccessibilityTraversalBefore.Value.Value;
			}
			if (nextProps.Activated.HasValue)
			{
				Element.Activated = nextProps.Activated.Value.Value;
			}
			if (nextProps.Alpha.HasValue)
			{
				Element.Alpha = nextProps.Alpha.Value.Value;
			}
			if (nextProps.Animation.HasValue)
			{
				Element.Animation = nextProps.Animation.Value.Value;
			}
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.BackgroundTintList.HasValue)
			{
				Element.BackgroundTintList = nextProps.BackgroundTintList.Value.Value;
			}
			if (nextProps.BackgroundTintMode.HasValue)
			{
				Element.BackgroundTintMode = nextProps.BackgroundTintMode.Value.Value;
			}
			if (nextProps.Bottom.HasValue)
			{
				Element.Bottom = nextProps.Bottom.Value.Value;
			}
			if (nextProps.Clickable.HasValue)
			{
				Element.Clickable = nextProps.Clickable.Value.Value;
			}
			if (nextProps.ClipBounds.HasValue)
			{
				Element.ClipBounds = nextProps.ClipBounds.Value.Value;
			}
			if (nextProps.ClipToOutline.HasValue)
			{
				Element.ClipToOutline = nextProps.ClipToOutline.Value.Value;
			}
			if (nextProps.ContentDescriptionFormatted.HasValue)
			{
				Element.ContentDescriptionFormatted = nextProps.ContentDescriptionFormatted.Value.Value;
			}
			if (nextProps.ContentDescription.HasValue)
			{
				Element.ContentDescription = nextProps.ContentDescription.Value.Value;
			}
			if (nextProps.ContextClickable.HasValue)
			{
				Element.ContextClickable = nextProps.ContextClickable.Value.Value;
			}
			if (nextProps.DefaultFocusHighlightEnabled.HasValue)
			{
				Element.DefaultFocusHighlightEnabled = nextProps.DefaultFocusHighlightEnabled.Value.Value;
			}
			if (nextProps.DrawingCacheBackgroundColor.HasValue)
			{
				Element.DrawingCacheBackgroundColor = nextProps.DrawingCacheBackgroundColor.Value.Value;
			}
			if (nextProps.DrawingCacheEnabled.HasValue)
			{
				Element.DrawingCacheEnabled = nextProps.DrawingCacheEnabled.Value.Value;
			}
			if (nextProps.DrawingCacheQuality.HasValue)
			{
				Element.DrawingCacheQuality = nextProps.DrawingCacheQuality.Value.Value;
			}
			if (nextProps.DuplicateParentStateEnabled.HasValue)
			{
				Element.DuplicateParentStateEnabled = nextProps.DuplicateParentStateEnabled.Value.Value;
			}
			if (nextProps.Elevation.HasValue)
			{
				Element.Elevation = nextProps.Elevation.Value.Value;
			}
			if (nextProps.Enabled.HasValue)
			{
				Element.Enabled = nextProps.Enabled.Value.Value;
			}
			if (nextProps.FilterTouchesWhenObscured.HasValue)
			{
				Element.FilterTouchesWhenObscured = nextProps.FilterTouchesWhenObscured.Value.Value;
			}
			if (nextProps.Focusable.HasValue)
			{
				Element.Focusable = nextProps.Focusable.Value.Value;
			}
			if (nextProps.FocusableInTouchMode.HasValue)
			{
				Element.FocusableInTouchMode = nextProps.FocusableInTouchMode.Value.Value;
			}
			if (nextProps.FocusedByDefault.HasValue)
			{
				Element.FocusedByDefault = nextProps.FocusedByDefault.Value.Value;
			}
			if (nextProps.Foreground.HasValue)
			{
				Element.Foreground = nextProps.Foreground.Value.Value;
			}
			if (nextProps.ForegroundTintList.HasValue)
			{
				Element.ForegroundTintList = nextProps.ForegroundTintList.Value.Value;
			}
			if (nextProps.ForegroundTintMode.HasValue)
			{
				Element.ForegroundTintMode = nextProps.ForegroundTintMode.Value.Value;
			}
			if (nextProps.HapticFeedbackEnabled.HasValue)
			{
				Element.HapticFeedbackEnabled = nextProps.HapticFeedbackEnabled.Value.Value;
			}
			if (nextProps.HasTransientState.HasValue)
			{
				Element.HasTransientState = nextProps.HasTransientState.Value.Value;
			}
			if (nextProps.HorizontalFadingEdgeEnabled.HasValue)
			{
				Element.HorizontalFadingEdgeEnabled = nextProps.HorizontalFadingEdgeEnabled.Value.Value;
			}
			if (nextProps.HorizontalScrollBarEnabled.HasValue)
			{
				Element.HorizontalScrollBarEnabled = nextProps.HorizontalScrollBarEnabled.Value.Value;
			}
			if (nextProps.Hovered.HasValue)
			{
				Element.Hovered = nextProps.Hovered.Value.Value;
			}
			if (nextProps.Id.HasValue)
			{
				Element.Id = nextProps.Id.Value.Value;
			}
			if (nextProps.ImportantForAccessibility.HasValue)
			{
				Element.ImportantForAccessibility = nextProps.ImportantForAccessibility.Value.Value;
			}
			if (nextProps.ImportantForAutofill.HasValue)
			{
				Element.ImportantForAutofill = nextProps.ImportantForAutofill.Value.Value;
			}
			if (nextProps.KeepScreenOn.HasValue)
			{
				Element.KeepScreenOn = nextProps.KeepScreenOn.Value.Value;
			}
			if (nextProps.KeyboardNavigationCluster.HasValue)
			{
				Element.KeyboardNavigationCluster = nextProps.KeyboardNavigationCluster.Value.Value;
			}
			if (nextProps.LabelFor.HasValue)
			{
				Element.LabelFor = nextProps.LabelFor.Value.Value;
			}
			if (nextProps.LayoutDirection.HasValue)
			{
				Element.LayoutDirection = nextProps.LayoutDirection.Value.Value;
			}
			if (nextProps.LayoutParameters.HasValue)
			{
				Element.LayoutParameters = nextProps.LayoutParameters.Value.Value;
			}
			if (nextProps.Left.HasValue)
			{
				Element.Left = nextProps.Left.Value.Value;
			}
			if (nextProps.LongClickable.HasValue)
			{
				Element.LongClickable = nextProps.LongClickable.Value.Value;
			}
			if (nextProps.NestedScrollingEnabled.HasValue)
			{
				Element.NestedScrollingEnabled = nextProps.NestedScrollingEnabled.Value.Value;
			}
			if (nextProps.NextClusterForwardId.HasValue)
			{
				Element.NextClusterForwardId = nextProps.NextClusterForwardId.Value.Value;
			}
			if (nextProps.NextFocusDownId.HasValue)
			{
				Element.NextFocusDownId = nextProps.NextFocusDownId.Value.Value;
			}
			if (nextProps.NextFocusForwardId.HasValue)
			{
				Element.NextFocusForwardId = nextProps.NextFocusForwardId.Value.Value;
			}
			if (nextProps.NextFocusLeftId.HasValue)
			{
				Element.NextFocusLeftId = nextProps.NextFocusLeftId.Value.Value;
			}
			if (nextProps.NextFocusRightId.HasValue)
			{
				Element.NextFocusRightId = nextProps.NextFocusRightId.Value.Value;
			}
			if (nextProps.NextFocusUpId.HasValue)
			{
				Element.NextFocusUpId = nextProps.NextFocusUpId.Value.Value;
			}
			if (nextProps.OnFocusChangeListener.HasValue)
			{
				Element.OnFocusChangeListener = nextProps.OnFocusChangeListener.Value.Value;
			}
			if (nextProps.OutlineProvider.HasValue)
			{
				Element.OutlineProvider = nextProps.OutlineProvider.Value.Value;
			}
			if (nextProps.OverScrollMode.HasValue)
			{
				Element.OverScrollMode = nextProps.OverScrollMode.Value.Value;
			}
			if (nextProps.PivotX.HasValue)
			{
				Element.PivotX = nextProps.PivotX.Value.Value;
			}
			if (nextProps.PivotY.HasValue)
			{
				Element.PivotY = nextProps.PivotY.Value.Value;
			}
			if (nextProps.PointerIcon.HasValue)
			{
				Element.PointerIcon = nextProps.PointerIcon.Value.Value;
			}
			if (nextProps.Pressed.HasValue)
			{
				Element.Pressed = nextProps.Pressed.Value.Value;
			}
			if (nextProps.RevealOnFocusHint.HasValue)
			{
				Element.RevealOnFocusHint = nextProps.RevealOnFocusHint.Value.Value;
			}
			if (nextProps.Right.HasValue)
			{
				Element.Right = nextProps.Right.Value.Value;
			}
			if (nextProps.Rotation.HasValue)
			{
				Element.Rotation = nextProps.Rotation.Value.Value;
			}
			if (nextProps.RotationX.HasValue)
			{
				Element.RotationX = nextProps.RotationX.Value.Value;
			}
			if (nextProps.RotationY.HasValue)
			{
				Element.RotationY = nextProps.RotationY.Value.Value;
			}
			if (nextProps.SaveEnabled.HasValue)
			{
				Element.SaveEnabled = nextProps.SaveEnabled.Value.Value;
			}
			if (nextProps.SaveFromParentEnabled.HasValue)
			{
				Element.SaveFromParentEnabled = nextProps.SaveFromParentEnabled.Value.Value;
			}
			if (nextProps.ScaleX.HasValue)
			{
				Element.ScaleX = nextProps.ScaleX.Value.Value;
			}
			if (nextProps.ScaleY.HasValue)
			{
				Element.ScaleY = nextProps.ScaleY.Value.Value;
			}
			if (nextProps.ScrollBarDefaultDelayBeforeFade.HasValue)
			{
				Element.ScrollBarDefaultDelayBeforeFade = nextProps.ScrollBarDefaultDelayBeforeFade.Value.Value;
			}
			if (nextProps.ScrollBarFadeDuration.HasValue)
			{
				Element.ScrollBarFadeDuration = nextProps.ScrollBarFadeDuration.Value.Value;
			}
			if (nextProps.ScrollBarSize.HasValue)
			{
				Element.ScrollBarSize = nextProps.ScrollBarSize.Value.Value;
			}
			if (nextProps.ScrollBarStyle.HasValue)
			{
				Element.ScrollBarStyle = nextProps.ScrollBarStyle.Value.Value;
			}
			if (nextProps.ScrollX.HasValue)
			{
				Element.ScrollX = nextProps.ScrollX.Value.Value;
			}
			if (nextProps.ScrollY.HasValue)
			{
				Element.ScrollY = nextProps.ScrollY.Value.Value;
			}
			if (nextProps.ScrollbarFadingEnabled.HasValue)
			{
				Element.ScrollbarFadingEnabled = nextProps.ScrollbarFadingEnabled.Value.Value;
			}
			if (nextProps.Selected.HasValue)
			{
				Element.Selected = nextProps.Selected.Value.Value;
			}
			if (nextProps.SoundEffectsEnabled.HasValue)
			{
				Element.SoundEffectsEnabled = nextProps.SoundEffectsEnabled.Value.Value;
			}
			if (nextProps.StateListAnimator.HasValue)
			{
				Element.StateListAnimator = nextProps.StateListAnimator.Value.Value;
			}
			if (nextProps.SystemUiVisibility.HasValue)
			{
				Element.SystemUiVisibility = nextProps.SystemUiVisibility.Value.Value;
			}
			if (nextProps.Tag.HasValue)
			{
				Element.Tag = nextProps.Tag.Value.Value;
			}
			if (nextProps.TextAlignment.HasValue)
			{
				Element.TextAlignment = nextProps.TextAlignment.Value.Value;
			}
			if (nextProps.TextDirection.HasValue)
			{
				Element.TextDirection = nextProps.TextDirection.Value.Value;
			}
			if (nextProps.TooltipTextFormatted.HasValue)
			{
				Element.TooltipTextFormatted = nextProps.TooltipTextFormatted.Value.Value;
			}
			if (nextProps.TooltipText.HasValue)
			{
				Element.TooltipText = nextProps.TooltipText.Value.Value;
			}
			if (nextProps.Top.HasValue)
			{
				Element.Top = nextProps.Top.Value.Value;
			}
			if (nextProps.TouchDelegate.HasValue)
			{
				Element.TouchDelegate = nextProps.TouchDelegate.Value.Value;
			}
			if (nextProps.TransitionName.HasValue)
			{
				Element.TransitionName = nextProps.TransitionName.Value.Value;
			}
			if (nextProps.TranslationX.HasValue)
			{
				Element.TranslationX = nextProps.TranslationX.Value.Value;
			}
			if (nextProps.TranslationY.HasValue)
			{
				Element.TranslationY = nextProps.TranslationY.Value.Value;
			}
			if (nextProps.TranslationZ.HasValue)
			{
				Element.TranslationZ = nextProps.TranslationZ.Value.Value;
			}
			if (nextProps.VerticalFadingEdgeEnabled.HasValue)
			{
				Element.VerticalFadingEdgeEnabled = nextProps.VerticalFadingEdgeEnabled.Value.Value;
			}
			if (nextProps.VerticalScrollBarEnabled.HasValue)
			{
				Element.VerticalScrollBarEnabled = nextProps.VerticalScrollBarEnabled.Value.Value;
			}
			if (nextProps.VerticalScrollbarPosition.HasValue)
			{
				Element.VerticalScrollbarPosition = nextProps.VerticalScrollbarPosition.Value.Value;
			}
			if (nextProps.Visibility.HasValue)
			{
				Element.Visibility = nextProps.Visibility.Value.Value;
			}
			if (nextProps.ApplyWindowInsets.HasValue)
			{
				Element.ApplyWindowInsets = nextProps.ApplyWindowInsets.Value.Value;
			}
			if (!ReferenceEquals(previous?.ViewAttachedToWindow, null) && ReferenceEquals(nextProps.ViewAttachedToWindow, null))
			{
				Element.ViewAttachedToWindow -= nextProps.ViewAttachedToWindow;
			}
			if (ReferenceEquals(previous?.ViewAttachedToWindow, null) && !ReferenceEquals(nextProps.ViewAttachedToWindow, null))
			{
				Element.ViewAttachedToWindow += nextProps.ViewAttachedToWindow;
			}
			if (!ReferenceEquals(previous?.ViewDetachedFromWindow, null) && ReferenceEquals(nextProps.ViewDetachedFromWindow, null))
			{
				Element.ViewDetachedFromWindow -= nextProps.ViewDetachedFromWindow;
			}
			if (ReferenceEquals(previous?.ViewDetachedFromWindow, null) && !ReferenceEquals(nextProps.ViewDetachedFromWindow, null))
			{
				Element.ViewDetachedFromWindow += nextProps.ViewDetachedFromWindow;
			}
			if (!ReferenceEquals(previous?.LayoutChange, null) && ReferenceEquals(nextProps.LayoutChange, null))
			{
				Element.LayoutChange -= nextProps.LayoutChange;
			}
			if (ReferenceEquals(previous?.LayoutChange, null) && !ReferenceEquals(nextProps.LayoutChange, null))
			{
				Element.LayoutChange += nextProps.LayoutChange;
			}
			if (!ReferenceEquals(previous?.CapturedPointer, null) && ReferenceEquals(nextProps.CapturedPointer, null))
			{
				Element.CapturedPointer -= nextProps.CapturedPointer;
			}
			if (ReferenceEquals(previous?.CapturedPointer, null) && !ReferenceEquals(nextProps.CapturedPointer, null))
			{
				Element.CapturedPointer += nextProps.CapturedPointer;
			}
			if (!ReferenceEquals(previous?.Click, null) && ReferenceEquals(nextProps.Click, null))
			{
				Element.Click -= nextProps.Click;
			}
			if (ReferenceEquals(previous?.Click, null) && !ReferenceEquals(nextProps.Click, null))
			{
				Element.Click += nextProps.Click;
			}
			if (!ReferenceEquals(previous?.ContextClick, null) && ReferenceEquals(nextProps.ContextClick, null))
			{
				Element.ContextClick -= nextProps.ContextClick;
			}
			if (ReferenceEquals(previous?.ContextClick, null) && !ReferenceEquals(nextProps.ContextClick, null))
			{
				Element.ContextClick += nextProps.ContextClick;
			}
			if (!ReferenceEquals(previous?.ContextMenuCreated, null) && ReferenceEquals(nextProps.ContextMenuCreated, null))
			{
				Element.ContextMenuCreated -= nextProps.ContextMenuCreated;
			}
			if (ReferenceEquals(previous?.ContextMenuCreated, null) && !ReferenceEquals(nextProps.ContextMenuCreated, null))
			{
				Element.ContextMenuCreated += nextProps.ContextMenuCreated;
			}
			if (!ReferenceEquals(previous?.Drag, null) && ReferenceEquals(nextProps.Drag, null))
			{
				Element.Drag -= nextProps.Drag;
			}
			if (ReferenceEquals(previous?.Drag, null) && !ReferenceEquals(nextProps.Drag, null))
			{
				Element.Drag += nextProps.Drag;
			}
			if (!ReferenceEquals(previous?.GenericMotion, null) && ReferenceEquals(nextProps.GenericMotion, null))
			{
				Element.GenericMotion -= nextProps.GenericMotion;
			}
			if (ReferenceEquals(previous?.GenericMotion, null) && !ReferenceEquals(nextProps.GenericMotion, null))
			{
				Element.GenericMotion += nextProps.GenericMotion;
			}
			if (!ReferenceEquals(previous?.Hover, null) && ReferenceEquals(nextProps.Hover, null))
			{
				Element.Hover -= nextProps.Hover;
			}
			if (ReferenceEquals(previous?.Hover, null) && !ReferenceEquals(nextProps.Hover, null))
			{
				Element.Hover += nextProps.Hover;
			}
			if (!ReferenceEquals(previous?.KeyPress, null) && ReferenceEquals(nextProps.KeyPress, null))
			{
				Element.KeyPress -= nextProps.KeyPress;
			}
			if (ReferenceEquals(previous?.KeyPress, null) && !ReferenceEquals(nextProps.KeyPress, null))
			{
				Element.KeyPress += nextProps.KeyPress;
			}
			if (!ReferenceEquals(previous?.LongClick, null) && ReferenceEquals(nextProps.LongClick, null))
			{
				Element.LongClick -= nextProps.LongClick;
			}
			if (ReferenceEquals(previous?.LongClick, null) && !ReferenceEquals(nextProps.LongClick, null))
			{
				Element.LongClick += nextProps.LongClick;
			}
			if (!ReferenceEquals(previous?.ScrollChange, null) && ReferenceEquals(nextProps.ScrollChange, null))
			{
				Element.ScrollChange -= nextProps.ScrollChange;
			}
			if (ReferenceEquals(previous?.ScrollChange, null) && !ReferenceEquals(nextProps.ScrollChange, null))
			{
				Element.ScrollChange += nextProps.ScrollChange;
			}
			if (!ReferenceEquals(previous?.SystemUiVisibilityChange, null) && ReferenceEquals(nextProps.SystemUiVisibilityChange, null))
			{
				Element.SystemUiVisibilityChange -= nextProps.SystemUiVisibilityChange;
			}
			if (ReferenceEquals(previous?.SystemUiVisibilityChange, null) && !ReferenceEquals(nextProps.SystemUiVisibilityChange, null))
			{
				Element.SystemUiVisibilityChange += nextProps.SystemUiVisibilityChange;
			}
			if (!ReferenceEquals(previous?.Touch, null) && ReferenceEquals(nextProps.Touch, null))
			{
				Element.Touch -= nextProps.Touch;
			}
			if (ReferenceEquals(previous?.Touch, null) && !ReferenceEquals(nextProps.Touch, null))
			{
				Element.Touch += nextProps.Touch;
			}
			if (!ReferenceEquals(previous?.FocusChange, null) && ReferenceEquals(nextProps.FocusChange, null))
			{
				Element.FocusChange -= nextProps.FocusChange;
			}
			if (ReferenceEquals(previous?.FocusChange, null) && !ReferenceEquals(nextProps.FocusChange, null))
			{
				Element.FocusChange += nextProps.FocusChange;
			}
		}
	}
}
