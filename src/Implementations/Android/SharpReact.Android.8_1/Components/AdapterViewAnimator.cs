using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class AdapterViewAnimator<TProps, TElement>: AdapterView<TProps, TElement>
		where TProps : Props.AdapterViewAnimator
		where TElement : global::Android.Widget.AdapterViewAnimator
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Adapter.HasValue)
			{
				Element.Adapter = nextProps.Adapter.Value.Value;
			}
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
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.AdapterViewAnimator.Views), nameof(SharpReact.Android.Props.AdapterViewAnimator));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
