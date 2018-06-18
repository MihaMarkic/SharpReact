using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class View: Core.Properties.SharpNativeProp
	{
		public ReactParam<global::Android.Views.AccessibilityLiveRegion>? AccessibilityLiveRegion { get; set; }
		public ReactParam<global::System.Int32>? AccessibilityTraversalAfter { get; set; }
		public ReactParam<global::System.Int32>? AccessibilityTraversalBefore { get; set; }
		public ReactParam<global::System.Boolean>? Activated { get; set; }
		public ReactParam<global::System.Single>? Alpha { get; set; }
		public ReactParam<global::Android.Views.Animations.Animation>? Animation { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? Background { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? BackgroundTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? BackgroundTintMode { get; set; }
		public ReactParam<global::System.Int32>? Bottom { get; set; }
		public ReactParam<global::System.Boolean>? Clickable { get; set; }
		public ReactParam<global::Android.Graphics.Rect>? ClipBounds { get; set; }
		public ReactParam<global::System.Boolean>? ClipToOutline { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? ContentDescriptionFormatted { get; set; }
		public ReactParam<global::System.String>? ContentDescription { get; set; }
		public ReactParam<global::System.Boolean>? ContextClickable { get; set; }
		public ReactParam<global::System.Boolean>? DefaultFocusHighlightEnabled { get; set; }
		public ReactParam<global::Android.Graphics.Color>? DrawingCacheBackgroundColor { get; set; }
		public ReactParam<global::System.Boolean>? DrawingCacheEnabled { get; set; }
		public ReactParam<global::Android.Views.DrawingCacheQuality>? DrawingCacheQuality { get; set; }
		public ReactParam<global::System.Boolean>? DuplicateParentStateEnabled { get; set; }
		public ReactParam<global::System.Single>? Elevation { get; set; }
		public ReactParam<global::System.Boolean>? Enabled { get; set; }
		public ReactParam<global::System.Boolean>? FilterTouchesWhenObscured { get; set; }
		public ReactParam<global::System.Boolean>? Focusable { get; set; }
		public ReactParam<global::System.Boolean>? FocusableInTouchMode { get; set; }
		public ReactParam<global::System.Boolean>? FocusedByDefault { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? Foreground { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? ForegroundTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ForegroundTintMode { get; set; }
		public ReactParam<global::System.Boolean>? HapticFeedbackEnabled { get; set; }
		public ReactParam<global::System.Boolean>? HasTransientState { get; set; }
		public ReactParam<global::System.Boolean>? HorizontalFadingEdgeEnabled { get; set; }
		public ReactParam<global::System.Boolean>? HorizontalScrollBarEnabled { get; set; }
		public ReactParam<global::System.Boolean>? Hovered { get; set; }
		public ReactParam<global::System.Int32>? Id { get; set; }
		public ReactParam<global::Android.Views.ImportantForAccessibility>? ImportantForAccessibility { get; set; }
		public ReactParam<global::Android.Views.ImportantForAutofill>? ImportantForAutofill { get; set; }
		public ReactParam<global::System.Boolean>? KeepScreenOn { get; set; }
		public ReactParam<global::System.Boolean>? KeyboardNavigationCluster { get; set; }
		public ReactParam<global::System.Int32>? LabelFor { get; set; }
		public ReactParam<global::Android.Views.LayoutDirection>? LayoutDirection { get; set; }
		public ReactParam<global::Android.Views.ViewGroup.LayoutParams>? LayoutParameters { get; set; }
		public ReactParam<global::System.Int32>? Left { get; set; }
		public ReactParam<global::System.Boolean>? LongClickable { get; set; }
		public ReactParam<global::System.Boolean>? NestedScrollingEnabled { get; set; }
		public ReactParam<global::System.Int32>? NextClusterForwardId { get; set; }
		public ReactParam<global::System.Int32>? NextFocusDownId { get; set; }
		public ReactParam<global::System.Int32>? NextFocusForwardId { get; set; }
		public ReactParam<global::System.Int32>? NextFocusLeftId { get; set; }
		public ReactParam<global::System.Int32>? NextFocusRightId { get; set; }
		public ReactParam<global::System.Int32>? NextFocusUpId { get; set; }
		public ReactParam<global::Android.Views.View.IOnFocusChangeListener>? OnFocusChangeListener { get; set; }
		public ReactParam<global::Android.Views.ViewOutlineProvider>? OutlineProvider { get; set; }
		public ReactParam<global::Android.Views.OverScrollMode>? OverScrollMode { get; set; }
		public ReactParam<global::System.Single>? PivotX { get; set; }
		public ReactParam<global::System.Single>? PivotY { get; set; }
		public ReactParam<global::Android.Views.PointerIcon>? PointerIcon { get; set; }
		public ReactParam<global::System.Boolean>? Pressed { get; set; }
		public ReactParam<global::System.Boolean>? RevealOnFocusHint { get; set; }
		public ReactParam<global::System.Int32>? Right { get; set; }
		public ReactParam<global::System.Single>? Rotation { get; set; }
		public ReactParam<global::System.Single>? RotationX { get; set; }
		public ReactParam<global::System.Single>? RotationY { get; set; }
		public ReactParam<global::System.Boolean>? SaveEnabled { get; set; }
		public ReactParam<global::System.Boolean>? SaveFromParentEnabled { get; set; }
		public ReactParam<global::System.Single>? ScaleX { get; set; }
		public ReactParam<global::System.Single>? ScaleY { get; set; }
		public ReactParam<global::System.Int32>? ScrollBarDefaultDelayBeforeFade { get; set; }
		public ReactParam<global::System.Int32>? ScrollBarFadeDuration { get; set; }
		public ReactParam<global::System.Int32>? ScrollBarSize { get; set; }
		public ReactParam<global::Android.Views.ScrollbarStyles>? ScrollBarStyle { get; set; }
		public ReactParam<global::System.Int32>? ScrollX { get; set; }
		public ReactParam<global::System.Int32>? ScrollY { get; set; }
		public ReactParam<global::System.Boolean>? ScrollbarFadingEnabled { get; set; }
		public ReactParam<global::System.Boolean>? Selected { get; set; }
		public ReactParam<global::System.Boolean>? SoundEffectsEnabled { get; set; }
		public ReactParam<global::Android.Animation.StateListAnimator>? StateListAnimator { get; set; }
		public ReactParam<global::Android.Views.StatusBarVisibility>? SystemUiVisibility { get; set; }
		public ReactParam<global::Java.Lang.Object>? Tag { get; set; }
		public ReactParam<global::Android.Views.TextAlignment>? TextAlignment { get; set; }
		public ReactParam<global::Android.Views.TextDirection>? TextDirection { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? TooltipTextFormatted { get; set; }
		public ReactParam<global::System.String>? TooltipText { get; set; }
		public ReactParam<global::System.Int32>? Top { get; set; }
		public ReactParam<global::Android.Views.TouchDelegate>? TouchDelegate { get; set; }
		public ReactParam<global::System.String>? TransitionName { get; set; }
		public ReactParam<global::System.Single>? TranslationX { get; set; }
		public ReactParam<global::System.Single>? TranslationY { get; set; }
		public ReactParam<global::System.Single>? TranslationZ { get; set; }
		public ReactParam<global::System.Boolean>? VerticalFadingEdgeEnabled { get; set; }
		public ReactParam<global::System.Boolean>? VerticalScrollBarEnabled { get; set; }
		public ReactParam<global::Android.Views.ScrollbarPosition>? VerticalScrollbarPosition { get; set; }
		public ReactParam<global::Android.Views.ViewStates>? Visibility { get; set; }
		public ReactParam<global::Android.Views.View.ApplyWindowInsetsHandler>? ApplyWindowInsets { get; set; }
		public System.EventHandler<global::Android.Views.View.ViewAttachedToWindowEventArgs> ViewAttachedToWindow { get; set; }
		public System.EventHandler<global::Android.Views.View.ViewDetachedFromWindowEventArgs> ViewDetachedFromWindow { get; set; }
		public System.EventHandler<global::Android.Views.View.LayoutChangeEventArgs> LayoutChange { get; set; }
		public System.EventHandler<global::Android.Views.View.CapturedPointerEventArgs> CapturedPointer { get; set; }
		public System.EventHandler Click { get; set; }
		public System.EventHandler<global::Android.Views.View.ContextClickEventArgs> ContextClick { get; set; }
		public System.EventHandler<global::Android.Views.View.CreateContextMenuEventArgs> ContextMenuCreated { get; set; }
		public System.EventHandler<global::Android.Views.View.DragEventArgs> Drag { get; set; }
		public System.EventHandler<global::Android.Views.View.GenericMotionEventArgs> GenericMotion { get; set; }
		public System.EventHandler<global::Android.Views.View.HoverEventArgs> Hover { get; set; }
		public System.EventHandler<global::Android.Views.View.KeyEventArgs> KeyPress { get; set; }
		public System.EventHandler<global::Android.Views.View.LongClickEventArgs> LongClick { get; set; }
		public System.EventHandler<global::Android.Views.View.ScrollChangeEventArgs> ScrollChange { get; set; }
		public System.EventHandler<global::Android.Views.View.SystemUiVisibilityChangeEventArgs> SystemUiVisibilityChange { get; set; }
		public System.EventHandler<global::Android.Views.View.TouchEventArgs> Touch { get; set; }
		public System.EventHandler<global::Android.Views.View.FocusChangeEventArgs> FocusChange { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.View<View, global::Android.Views.View>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return AccessibilityLiveRegion;
				yield return AccessibilityTraversalAfter;
				yield return AccessibilityTraversalBefore;
				yield return Activated;
				yield return Alpha;
				yield return Animation;
				yield return Background;
				yield return BackgroundTintList;
				yield return BackgroundTintMode;
				yield return Bottom;
				yield return Clickable;
				yield return ClipBounds;
				yield return ClipToOutline;
				yield return ContentDescriptionFormatted;
				yield return ContentDescription;
				yield return ContextClickable;
				yield return DefaultFocusHighlightEnabled;
				yield return DrawingCacheBackgroundColor;
				yield return DrawingCacheEnabled;
				yield return DrawingCacheQuality;
				yield return DuplicateParentStateEnabled;
				yield return Elevation;
				yield return Enabled;
				yield return FilterTouchesWhenObscured;
				yield return Focusable;
				yield return FocusableInTouchMode;
				yield return FocusedByDefault;
				yield return Foreground;
				yield return ForegroundTintList;
				yield return ForegroundTintMode;
				yield return HapticFeedbackEnabled;
				yield return HasTransientState;
				yield return HorizontalFadingEdgeEnabled;
				yield return HorizontalScrollBarEnabled;
				yield return Hovered;
				yield return Id;
				yield return ImportantForAccessibility;
				yield return ImportantForAutofill;
				yield return KeepScreenOn;
				yield return KeyboardNavigationCluster;
				yield return LabelFor;
				yield return LayoutDirection;
				yield return LayoutParameters;
				yield return Left;
				yield return LongClickable;
				yield return NestedScrollingEnabled;
				yield return NextClusterForwardId;
				yield return NextFocusDownId;
				yield return NextFocusForwardId;
				yield return NextFocusLeftId;
				yield return NextFocusRightId;
				yield return NextFocusUpId;
				yield return OnFocusChangeListener;
				yield return OutlineProvider;
				yield return OverScrollMode;
				yield return PivotX;
				yield return PivotY;
				yield return PointerIcon;
				yield return Pressed;
				yield return RevealOnFocusHint;
				yield return Right;
				yield return Rotation;
				yield return RotationX;
				yield return RotationY;
				yield return SaveEnabled;
				yield return SaveFromParentEnabled;
				yield return ScaleX;
				yield return ScaleY;
				yield return ScrollBarDefaultDelayBeforeFade;
				yield return ScrollBarFadeDuration;
				yield return ScrollBarSize;
				yield return ScrollBarStyle;
				yield return ScrollX;
				yield return ScrollY;
				yield return ScrollbarFadingEnabled;
				yield return Selected;
				yield return SoundEffectsEnabled;
				yield return StateListAnimator;
				yield return SystemUiVisibility;
				yield return Tag;
				yield return TextAlignment;
				yield return TextDirection;
				yield return TooltipTextFormatted;
				yield return TooltipText;
				yield return Top;
				yield return TouchDelegate;
				yield return TransitionName;
				yield return TranslationX;
				yield return TranslationY;
				yield return TranslationZ;
				yield return VerticalFadingEdgeEnabled;
				yield return VerticalScrollBarEnabled;
				yield return VerticalScrollbarPosition;
				yield return Visibility;
				yield return ApplyWindowInsets;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
