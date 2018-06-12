using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ViewGroup<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.ViewGroup
		where TElement : global::Android.Views.ViewGroup
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.DescendantFocusability.HasValue)
			{
				Element.DescendantFocusability = nextProps.DescendantFocusability.Value.Value;
			}
			if (nextProps.LayoutAnimation.HasValue)
			{
				Element.LayoutAnimation = nextProps.LayoutAnimation.Value.Value;
			}
			if (nextProps.LayoutAnimationListener.HasValue)
			{
				Element.LayoutAnimationListener = nextProps.LayoutAnimationListener.Value.Value;
			}
			if (nextProps.LayoutMode.HasValue)
			{
				Element.LayoutMode = nextProps.LayoutMode.Value.Value;
			}
			if (nextProps.LayoutTransition.HasValue)
			{
				Element.LayoutTransition = nextProps.LayoutTransition.Value.Value;
			}
			if (nextProps.MotionEventSplittingEnabled.HasValue)
			{
				Element.MotionEventSplittingEnabled = nextProps.MotionEventSplittingEnabled.Value.Value;
			}
			if (nextProps.PersistentDrawingCache.HasValue)
			{
				Element.PersistentDrawingCache = nextProps.PersistentDrawingCache.Value.Value;
			}
			if (nextProps.TouchscreenBlocksFocus.HasValue)
			{
				Element.TouchscreenBlocksFocus = nextProps.TouchscreenBlocksFocus.Value.Value;
			}
			if (nextProps.TransitionGroup.HasValue)
			{
				Element.TransitionGroup = nextProps.TransitionGroup.Value.Value;
			}
			if (!ReferenceEquals(previous?.ChildViewAdded, null) && ReferenceEquals(nextProps.ChildViewAdded, null))
			{
				Element.ChildViewAdded -= nextProps.ChildViewAdded;
			}
			if (ReferenceEquals(previous?.ChildViewAdded, null) && !ReferenceEquals(nextProps.ChildViewAdded, null))
			{
				Element.ChildViewAdded += nextProps.ChildViewAdded;
			}
			if (!ReferenceEquals(previous?.ChildViewRemoved, null) && ReferenceEquals(nextProps.ChildViewRemoved, null))
			{
				Element.ChildViewRemoved -= nextProps.ChildViewRemoved;
			}
			if (ReferenceEquals(previous?.ChildViewRemoved, null) && !ReferenceEquals(nextProps.ChildViewRemoved, null))
			{
				Element.ChildViewRemoved += nextProps.ChildViewRemoved;
			}
			if (!ReferenceEquals(previous?.AnimationEnd, null) && ReferenceEquals(nextProps.AnimationEnd, null))
			{
				Element.AnimationEnd -= nextProps.AnimationEnd;
			}
			if (ReferenceEquals(previous?.AnimationEnd, null) && !ReferenceEquals(nextProps.AnimationEnd, null))
			{
				Element.AnimationEnd += nextProps.AnimationEnd;
			}
			if (!ReferenceEquals(previous?.AnimationRepeat, null) && ReferenceEquals(nextProps.AnimationRepeat, null))
			{
				Element.AnimationRepeat -= nextProps.AnimationRepeat;
			}
			if (ReferenceEquals(previous?.AnimationRepeat, null) && !ReferenceEquals(nextProps.AnimationRepeat, null))
			{
				Element.AnimationRepeat += nextProps.AnimationRepeat;
			}
			if (!ReferenceEquals(previous?.AnimationStart, null) && ReferenceEquals(nextProps.AnimationStart, null))
			{
				Element.AnimationStart -= nextProps.AnimationStart;
			}
			if (ReferenceEquals(previous?.AnimationStart, null) && !ReferenceEquals(nextProps.AnimationStart, null))
			{
				Element.AnimationStart += nextProps.AnimationStart;
			}
		}
	}
}
