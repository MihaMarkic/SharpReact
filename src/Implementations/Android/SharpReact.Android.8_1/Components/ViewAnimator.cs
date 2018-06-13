using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ViewAnimator<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.ViewAnimator
		where TElement : global::Android.Widget.ViewAnimator
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ViewAnimator(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.DisplayedChild.HasValue)
			{
				Element.DisplayedChild = nextProps.DisplayedChild.Value.Value;
			}
			if (nextProps.InAnimation.HasValue)
			{
				Element.InAnimation = nextProps.InAnimation.Value.Value;
			}
			if (nextProps.OutAnimation.HasValue)
			{
				Element.OutAnimation = nextProps.OutAnimation.Value.Value;
			}
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.ViewAnimator.Views), nameof(SharpReact.Android.Props.ViewAnimator));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
