using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ViewGroup<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.ViewGroup
		where TElement : global::Android.Views.ViewGroup
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateViewGroupWithInstanceProperties(Element, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.ViewGroup.Views), nameof(SharpReact.Android.Props.ViewGroup));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateViewGroupWithInstanceProperties(element, null, props);
		}
		static void UpdateViewGroupWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.DescendantFocusability.HasValue)
			{
				element.DescendantFocusability = nextProps.DescendantFocusability.Value.Value;
			}
			if (nextProps.LayoutAnimation.HasValue)
			{
				element.LayoutAnimation = nextProps.LayoutAnimation.Value.Value;
			}
			if (nextProps.LayoutAnimationListener.HasValue)
			{
				element.LayoutAnimationListener = nextProps.LayoutAnimationListener.Value.Value;
			}
			if (nextProps.LayoutMode.HasValue)
			{
				element.LayoutMode = nextProps.LayoutMode.Value.Value;
			}
			if (nextProps.LayoutTransition.HasValue)
			{
				element.LayoutTransition = nextProps.LayoutTransition.Value.Value;
			}
			if (nextProps.MotionEventSplittingEnabled.HasValue)
			{
				element.MotionEventSplittingEnabled = nextProps.MotionEventSplittingEnabled.Value.Value;
			}
			if (nextProps.PersistentDrawingCache.HasValue)
			{
				element.PersistentDrawingCache = nextProps.PersistentDrawingCache.Value.Value;
			}
			if (nextProps.TouchscreenBlocksFocus.HasValue)
			{
				element.TouchscreenBlocksFocus = nextProps.TouchscreenBlocksFocus.Value.Value;
			}
			if (nextProps.TransitionGroup.HasValue)
			{
				element.TransitionGroup = nextProps.TransitionGroup.Value.Value;
			}
			if (!(previous?.ChildViewAdded is null) && nextProps.ChildViewAdded is null)
			{
				element.ChildViewAdded -= nextProps.ChildViewAdded;
			}
			if (previous?.ChildViewAdded is null && !(nextProps.ChildViewAdded is null))
			{
				element.ChildViewAdded += nextProps.ChildViewAdded;
			}
			if (!(previous?.ChildViewRemoved is null) && nextProps.ChildViewRemoved is null)
			{
				element.ChildViewRemoved -= nextProps.ChildViewRemoved;
			}
			if (previous?.ChildViewRemoved is null && !(nextProps.ChildViewRemoved is null))
			{
				element.ChildViewRemoved += nextProps.ChildViewRemoved;
			}
			if (!(previous?.AnimationEnd is null) && nextProps.AnimationEnd is null)
			{
				element.AnimationEnd -= nextProps.AnimationEnd;
			}
			if (previous?.AnimationEnd is null && !(nextProps.AnimationEnd is null))
			{
				element.AnimationEnd += nextProps.AnimationEnd;
			}
			if (!(previous?.AnimationRepeat is null) && nextProps.AnimationRepeat is null)
			{
				element.AnimationRepeat -= nextProps.AnimationRepeat;
			}
			if (previous?.AnimationRepeat is null && !(nextProps.AnimationRepeat is null))
			{
				element.AnimationRepeat += nextProps.AnimationRepeat;
			}
			if (!(previous?.AnimationStart is null) && nextProps.AnimationStart is null)
			{
				element.AnimationStart -= nextProps.AnimationStart;
			}
			if (previous?.AnimationStart is null && !(nextProps.AnimationStart is null))
			{
				element.AnimationStart += nextProps.AnimationStart;
			}
		}
	}
}
