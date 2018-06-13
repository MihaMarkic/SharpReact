using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class ViewGroup: View
	{
		public ReactParam<global::Android.Views.DescendantFocusability>? DescendantFocusability { get; set; }
		public ReactParam<global::Android.Views.Animations.LayoutAnimationController>? LayoutAnimation { get; set; }
		public ReactParam<global::Android.Views.Animations.Animation.IAnimationListener>? LayoutAnimationListener { get; set; }
		public ReactParam<global::Android.Views.ViewLayoutMode>? LayoutMode { get; set; }
		public ReactParam<global::Android.Animation.LayoutTransition>? LayoutTransition { get; set; }
		public ReactParam<global::System.Boolean>? MotionEventSplittingEnabled { get; set; }
		public ReactParam<global::Android.Views.PersistentDrawingCaches>? PersistentDrawingCache { get; set; }
		public ReactParam<global::System.Boolean>? TouchscreenBlocksFocus { get; set; }
		public ReactParam<global::System.Boolean>? TransitionGroup { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		public System.EventHandler<global::Android.Views.ViewGroup.ChildViewAddedEventArgs> ChildViewAdded { get; set; }
		public System.EventHandler<global::Android.Views.ViewGroup.ChildViewRemovedEventArgs> ChildViewRemoved { get; set; }
		public System.EventHandler<global::Android.Views.Animations.Animation.AnimationEndEventArgs> AnimationEnd { get; set; }
		public System.EventHandler<global::Android.Views.Animations.Animation.AnimationRepeatEventArgs> AnimationRepeat { get; set; }
		public System.EventHandler<global::Android.Views.Animations.Animation.AnimationStartEventArgs> AnimationStart { get; set; }
	}
}
