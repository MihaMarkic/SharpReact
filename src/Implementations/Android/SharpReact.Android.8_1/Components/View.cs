using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class View<TProps, TElement>: SharpAndroidComponent<TProps, object, TElement>
		where TProps : Props.View
		where TElement : global::Android.Views.View
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Views.View(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateViewWithInstanceProperties(element, null, props);
		}
		static void UpdateViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.AccessibilityLiveRegion.HasValue)
			{
				element.AccessibilityLiveRegion = nextProps.AccessibilityLiveRegion.Value.Value;
			}
			if (nextProps.AccessibilityTraversalAfter.HasValue)
			{
				element.AccessibilityTraversalAfter = nextProps.AccessibilityTraversalAfter.Value.Value;
			}
			if (nextProps.AccessibilityTraversalBefore.HasValue)
			{
				element.AccessibilityTraversalBefore = nextProps.AccessibilityTraversalBefore.Value.Value;
			}
			if (nextProps.Activated.HasValue)
			{
				element.Activated = nextProps.Activated.Value.Value;
			}
			if (nextProps.Alpha.HasValue)
			{
				element.Alpha = nextProps.Alpha.Value.Value;
			}
			if (nextProps.Animation.HasValue)
			{
				element.Animation = nextProps.Animation.Value.Value;
			}
			if (nextProps.Background.HasValue)
			{
				element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.BackgroundTintList.HasValue)
			{
				element.BackgroundTintList = nextProps.BackgroundTintList.Value.Value;
			}
			if (nextProps.BackgroundTintMode.HasValue)
			{
				element.BackgroundTintMode = nextProps.BackgroundTintMode.Value.Value;
			}
			if (nextProps.Bottom.HasValue)
			{
				element.Bottom = nextProps.Bottom.Value.Value;
			}
			if (nextProps.Clickable.HasValue)
			{
				element.Clickable = nextProps.Clickable.Value.Value;
			}
			if (nextProps.ClipBounds.HasValue)
			{
				element.ClipBounds = nextProps.ClipBounds.Value.Value;
			}
			if (nextProps.ClipToOutline.HasValue)
			{
				element.ClipToOutline = nextProps.ClipToOutline.Value.Value;
			}
			if (nextProps.ContentDescriptionFormatted.HasValue)
			{
				element.ContentDescriptionFormatted = nextProps.ContentDescriptionFormatted.Value.Value;
			}
			if (nextProps.ContentDescription.HasValue)
			{
				element.ContentDescription = nextProps.ContentDescription.Value.Value;
			}
			if (nextProps.ContextClickable.HasValue)
			{
				element.ContextClickable = nextProps.ContextClickable.Value.Value;
			}
			if (nextProps.DefaultFocusHighlightEnabled.HasValue)
			{
				element.DefaultFocusHighlightEnabled = nextProps.DefaultFocusHighlightEnabled.Value.Value;
			}
			if (nextProps.DrawingCacheBackgroundColor.HasValue)
			{
				element.DrawingCacheBackgroundColor = nextProps.DrawingCacheBackgroundColor.Value.Value;
			}
			if (nextProps.DrawingCacheEnabled.HasValue)
			{
				element.DrawingCacheEnabled = nextProps.DrawingCacheEnabled.Value.Value;
			}
			if (nextProps.DrawingCacheQuality.HasValue)
			{
				element.DrawingCacheQuality = nextProps.DrawingCacheQuality.Value.Value;
			}
			if (nextProps.DuplicateParentStateEnabled.HasValue)
			{
				element.DuplicateParentStateEnabled = nextProps.DuplicateParentStateEnabled.Value.Value;
			}
			if (nextProps.Elevation.HasValue)
			{
				element.Elevation = nextProps.Elevation.Value.Value;
			}
			if (nextProps.Enabled.HasValue)
			{
				element.Enabled = nextProps.Enabled.Value.Value;
			}
			if (nextProps.FilterTouchesWhenObscured.HasValue)
			{
				element.FilterTouchesWhenObscured = nextProps.FilterTouchesWhenObscured.Value.Value;
			}
			if (nextProps.Focusable.HasValue)
			{
				element.Focusable = nextProps.Focusable.Value.Value;
			}
			if (nextProps.FocusableInTouchMode.HasValue)
			{
				element.FocusableInTouchMode = nextProps.FocusableInTouchMode.Value.Value;
			}
			if (nextProps.FocusedByDefault.HasValue)
			{
				element.FocusedByDefault = nextProps.FocusedByDefault.Value.Value;
			}
			if (nextProps.Foreground.HasValue)
			{
				element.Foreground = nextProps.Foreground.Value.Value;
			}
			if (nextProps.ForegroundTintList.HasValue)
			{
				element.ForegroundTintList = nextProps.ForegroundTintList.Value.Value;
			}
			if (nextProps.ForegroundTintMode.HasValue)
			{
				element.ForegroundTintMode = nextProps.ForegroundTintMode.Value.Value;
			}
			if (nextProps.HapticFeedbackEnabled.HasValue)
			{
				element.HapticFeedbackEnabled = nextProps.HapticFeedbackEnabled.Value.Value;
			}
			if (nextProps.HasTransientState.HasValue)
			{
				element.HasTransientState = nextProps.HasTransientState.Value.Value;
			}
			if (nextProps.HorizontalFadingEdgeEnabled.HasValue)
			{
				element.HorizontalFadingEdgeEnabled = nextProps.HorizontalFadingEdgeEnabled.Value.Value;
			}
			if (nextProps.HorizontalScrollBarEnabled.HasValue)
			{
				element.HorizontalScrollBarEnabled = nextProps.HorizontalScrollBarEnabled.Value.Value;
			}
			if (nextProps.Hovered.HasValue)
			{
				element.Hovered = nextProps.Hovered.Value.Value;
			}
			if (nextProps.Id.HasValue)
			{
				element.Id = nextProps.Id.Value.Value;
			}
			if (nextProps.ImportantForAccessibility.HasValue)
			{
				element.ImportantForAccessibility = nextProps.ImportantForAccessibility.Value.Value;
			}
			if (nextProps.ImportantForAutofill.HasValue)
			{
				element.ImportantForAutofill = nextProps.ImportantForAutofill.Value.Value;
			}
			if (nextProps.KeepScreenOn.HasValue)
			{
				element.KeepScreenOn = nextProps.KeepScreenOn.Value.Value;
			}
			if (nextProps.KeyboardNavigationCluster.HasValue)
			{
				element.KeyboardNavigationCluster = nextProps.KeyboardNavigationCluster.Value.Value;
			}
			if (nextProps.LabelFor.HasValue)
			{
				element.LabelFor = nextProps.LabelFor.Value.Value;
			}
			if (nextProps.LayoutDirection.HasValue)
			{
				element.LayoutDirection = nextProps.LayoutDirection.Value.Value;
			}
			if (nextProps.LayoutParameters.HasValue)
			{
				element.LayoutParameters = nextProps.LayoutParameters.Value.Value;
			}
			if (nextProps.Left.HasValue)
			{
				element.Left = nextProps.Left.Value.Value;
			}
			if (nextProps.LongClickable.HasValue)
			{
				element.LongClickable = nextProps.LongClickable.Value.Value;
			}
			if (nextProps.NestedScrollingEnabled.HasValue)
			{
				element.NestedScrollingEnabled = nextProps.NestedScrollingEnabled.Value.Value;
			}
			if (nextProps.NextClusterForwardId.HasValue)
			{
				element.NextClusterForwardId = nextProps.NextClusterForwardId.Value.Value;
			}
			if (nextProps.NextFocusDownId.HasValue)
			{
				element.NextFocusDownId = nextProps.NextFocusDownId.Value.Value;
			}
			if (nextProps.NextFocusForwardId.HasValue)
			{
				element.NextFocusForwardId = nextProps.NextFocusForwardId.Value.Value;
			}
			if (nextProps.NextFocusLeftId.HasValue)
			{
				element.NextFocusLeftId = nextProps.NextFocusLeftId.Value.Value;
			}
			if (nextProps.NextFocusRightId.HasValue)
			{
				element.NextFocusRightId = nextProps.NextFocusRightId.Value.Value;
			}
			if (nextProps.NextFocusUpId.HasValue)
			{
				element.NextFocusUpId = nextProps.NextFocusUpId.Value.Value;
			}
			if (nextProps.OnFocusChangeListener.HasValue)
			{
				element.OnFocusChangeListener = nextProps.OnFocusChangeListener.Value.Value;
			}
			if (nextProps.OutlineProvider.HasValue)
			{
				element.OutlineProvider = nextProps.OutlineProvider.Value.Value;
			}
			if (nextProps.OverScrollMode.HasValue)
			{
				element.OverScrollMode = nextProps.OverScrollMode.Value.Value;
			}
			if (nextProps.PivotX.HasValue)
			{
				element.PivotX = nextProps.PivotX.Value.Value;
			}
			if (nextProps.PivotY.HasValue)
			{
				element.PivotY = nextProps.PivotY.Value.Value;
			}
			if (nextProps.PointerIcon.HasValue)
			{
				element.PointerIcon = nextProps.PointerIcon.Value.Value;
			}
			if (nextProps.Pressed.HasValue)
			{
				element.Pressed = nextProps.Pressed.Value.Value;
			}
			if (nextProps.RevealOnFocusHint.HasValue)
			{
				element.RevealOnFocusHint = nextProps.RevealOnFocusHint.Value.Value;
			}
			if (nextProps.Right.HasValue)
			{
				element.Right = nextProps.Right.Value.Value;
			}
			if (nextProps.Rotation.HasValue)
			{
				element.Rotation = nextProps.Rotation.Value.Value;
			}
			if (nextProps.RotationX.HasValue)
			{
				element.RotationX = nextProps.RotationX.Value.Value;
			}
			if (nextProps.RotationY.HasValue)
			{
				element.RotationY = nextProps.RotationY.Value.Value;
			}
			if (nextProps.SaveEnabled.HasValue)
			{
				element.SaveEnabled = nextProps.SaveEnabled.Value.Value;
			}
			if (nextProps.SaveFromParentEnabled.HasValue)
			{
				element.SaveFromParentEnabled = nextProps.SaveFromParentEnabled.Value.Value;
			}
			if (nextProps.ScaleX.HasValue)
			{
				element.ScaleX = nextProps.ScaleX.Value.Value;
			}
			if (nextProps.ScaleY.HasValue)
			{
				element.ScaleY = nextProps.ScaleY.Value.Value;
			}
			if (nextProps.ScrollBarDefaultDelayBeforeFade.HasValue)
			{
				element.ScrollBarDefaultDelayBeforeFade = nextProps.ScrollBarDefaultDelayBeforeFade.Value.Value;
			}
			if (nextProps.ScrollBarFadeDuration.HasValue)
			{
				element.ScrollBarFadeDuration = nextProps.ScrollBarFadeDuration.Value.Value;
			}
			if (nextProps.ScrollBarSize.HasValue)
			{
				element.ScrollBarSize = nextProps.ScrollBarSize.Value.Value;
			}
			if (nextProps.ScrollBarStyle.HasValue)
			{
				element.ScrollBarStyle = nextProps.ScrollBarStyle.Value.Value;
			}
			if (nextProps.ScrollX.HasValue)
			{
				element.ScrollX = nextProps.ScrollX.Value.Value;
			}
			if (nextProps.ScrollY.HasValue)
			{
				element.ScrollY = nextProps.ScrollY.Value.Value;
			}
			if (nextProps.ScrollbarFadingEnabled.HasValue)
			{
				element.ScrollbarFadingEnabled = nextProps.ScrollbarFadingEnabled.Value.Value;
			}
			if (nextProps.Selected.HasValue)
			{
				element.Selected = nextProps.Selected.Value.Value;
			}
			if (nextProps.SoundEffectsEnabled.HasValue)
			{
				element.SoundEffectsEnabled = nextProps.SoundEffectsEnabled.Value.Value;
			}
			if (nextProps.StateListAnimator.HasValue)
			{
				element.StateListAnimator = nextProps.StateListAnimator.Value.Value;
			}
			if (nextProps.SystemUiVisibility.HasValue)
			{
				element.SystemUiVisibility = nextProps.SystemUiVisibility.Value.Value;
			}
			if (nextProps.Tag.HasValue)
			{
				element.Tag = nextProps.Tag.Value.Value;
			}
			if (nextProps.TextAlignment.HasValue)
			{
				element.TextAlignment = nextProps.TextAlignment.Value.Value;
			}
			if (nextProps.TextDirection.HasValue)
			{
				element.TextDirection = nextProps.TextDirection.Value.Value;
			}
			if (nextProps.TooltipTextFormatted.HasValue)
			{
				element.TooltipTextFormatted = nextProps.TooltipTextFormatted.Value.Value;
			}
			if (nextProps.TooltipText.HasValue)
			{
				element.TooltipText = nextProps.TooltipText.Value.Value;
			}
			if (nextProps.Top.HasValue)
			{
				element.Top = nextProps.Top.Value.Value;
			}
			if (nextProps.TouchDelegate.HasValue)
			{
				element.TouchDelegate = nextProps.TouchDelegate.Value.Value;
			}
			if (nextProps.TransitionName.HasValue)
			{
				element.TransitionName = nextProps.TransitionName.Value.Value;
			}
			if (nextProps.TranslationX.HasValue)
			{
				element.TranslationX = nextProps.TranslationX.Value.Value;
			}
			if (nextProps.TranslationY.HasValue)
			{
				element.TranslationY = nextProps.TranslationY.Value.Value;
			}
			if (nextProps.TranslationZ.HasValue)
			{
				element.TranslationZ = nextProps.TranslationZ.Value.Value;
			}
			if (nextProps.VerticalFadingEdgeEnabled.HasValue)
			{
				element.VerticalFadingEdgeEnabled = nextProps.VerticalFadingEdgeEnabled.Value.Value;
			}
			if (nextProps.VerticalScrollBarEnabled.HasValue)
			{
				element.VerticalScrollBarEnabled = nextProps.VerticalScrollBarEnabled.Value.Value;
			}
			if (nextProps.VerticalScrollbarPosition.HasValue)
			{
				element.VerticalScrollbarPosition = nextProps.VerticalScrollbarPosition.Value.Value;
			}
			if (nextProps.Visibility.HasValue)
			{
				element.Visibility = nextProps.Visibility.Value.Value;
			}
			if (nextProps.ApplyWindowInsets.HasValue)
			{
				element.ApplyWindowInsets = nextProps.ApplyWindowInsets.Value.Value;
			}
			if (!(previous?.ViewAttachedToWindow is null) && nextProps.ViewAttachedToWindow is null)
			{
				element.ViewAttachedToWindow -= nextProps.ViewAttachedToWindow;
			}
			if (previous?.ViewAttachedToWindow is null && !(nextProps.ViewAttachedToWindow is null))
			{
				element.ViewAttachedToWindow += nextProps.ViewAttachedToWindow;
			}
			if (!(previous?.ViewDetachedFromWindow is null) && nextProps.ViewDetachedFromWindow is null)
			{
				element.ViewDetachedFromWindow -= nextProps.ViewDetachedFromWindow;
			}
			if (previous?.ViewDetachedFromWindow is null && !(nextProps.ViewDetachedFromWindow is null))
			{
				element.ViewDetachedFromWindow += nextProps.ViewDetachedFromWindow;
			}
			if (!(previous?.LayoutChange is null) && nextProps.LayoutChange is null)
			{
				element.LayoutChange -= nextProps.LayoutChange;
			}
			if (previous?.LayoutChange is null && !(nextProps.LayoutChange is null))
			{
				element.LayoutChange += nextProps.LayoutChange;
			}
			if (!(previous?.CapturedPointer is null) && nextProps.CapturedPointer is null)
			{
				element.CapturedPointer -= nextProps.CapturedPointer;
			}
			if (previous?.CapturedPointer is null && !(nextProps.CapturedPointer is null))
			{
				element.CapturedPointer += nextProps.CapturedPointer;
			}
			if (!(previous?.Click is null) && nextProps.Click is null)
			{
				element.Click -= nextProps.Click;
			}
			if (previous?.Click is null && !(nextProps.Click is null))
			{
				element.Click += nextProps.Click;
			}
			if (!(previous?.ContextClick is null) && nextProps.ContextClick is null)
			{
				element.ContextClick -= nextProps.ContextClick;
			}
			if (previous?.ContextClick is null && !(nextProps.ContextClick is null))
			{
				element.ContextClick += nextProps.ContextClick;
			}
			if (!(previous?.ContextMenuCreated is null) && nextProps.ContextMenuCreated is null)
			{
				element.ContextMenuCreated -= nextProps.ContextMenuCreated;
			}
			if (previous?.ContextMenuCreated is null && !(nextProps.ContextMenuCreated is null))
			{
				element.ContextMenuCreated += nextProps.ContextMenuCreated;
			}
			if (!(previous?.Drag is null) && nextProps.Drag is null)
			{
				element.Drag -= nextProps.Drag;
			}
			if (previous?.Drag is null && !(nextProps.Drag is null))
			{
				element.Drag += nextProps.Drag;
			}
			if (!(previous?.GenericMotion is null) && nextProps.GenericMotion is null)
			{
				element.GenericMotion -= nextProps.GenericMotion;
			}
			if (previous?.GenericMotion is null && !(nextProps.GenericMotion is null))
			{
				element.GenericMotion += nextProps.GenericMotion;
			}
			if (!(previous?.Hover is null) && nextProps.Hover is null)
			{
				element.Hover -= nextProps.Hover;
			}
			if (previous?.Hover is null && !(nextProps.Hover is null))
			{
				element.Hover += nextProps.Hover;
			}
			if (!(previous?.KeyPress is null) && nextProps.KeyPress is null)
			{
				element.KeyPress -= nextProps.KeyPress;
			}
			if (previous?.KeyPress is null && !(nextProps.KeyPress is null))
			{
				element.KeyPress += nextProps.KeyPress;
			}
			if (!(previous?.LongClick is null) && nextProps.LongClick is null)
			{
				element.LongClick -= nextProps.LongClick;
			}
			if (previous?.LongClick is null && !(nextProps.LongClick is null))
			{
				element.LongClick += nextProps.LongClick;
			}
			if (!(previous?.ScrollChange is null) && nextProps.ScrollChange is null)
			{
				element.ScrollChange -= nextProps.ScrollChange;
			}
			if (previous?.ScrollChange is null && !(nextProps.ScrollChange is null))
			{
				element.ScrollChange += nextProps.ScrollChange;
			}
			if (!(previous?.SystemUiVisibilityChange is null) && nextProps.SystemUiVisibilityChange is null)
			{
				element.SystemUiVisibilityChange -= nextProps.SystemUiVisibilityChange;
			}
			if (previous?.SystemUiVisibilityChange is null && !(nextProps.SystemUiVisibilityChange is null))
			{
				element.SystemUiVisibilityChange += nextProps.SystemUiVisibilityChange;
			}
			if (!(previous?.Touch is null) && nextProps.Touch is null)
			{
				element.Touch -= nextProps.Touch;
			}
			if (previous?.Touch is null && !(nextProps.Touch is null))
			{
				element.Touch += nextProps.Touch;
			}
			if (!(previous?.FocusChange is null) && nextProps.FocusChange is null)
			{
				element.FocusChange -= nextProps.FocusChange;
			}
			if (previous?.FocusChange is null && !(nextProps.FocusChange is null))
			{
				element.FocusChange += nextProps.FocusChange;
			}
		}
	}
}
