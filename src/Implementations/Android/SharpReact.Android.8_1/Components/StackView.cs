using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class StackView<TProps, TElement>: AdapterViewAnimator<TProps, TElement>
		where TProps : Props.StackView
		where TElement : global::Android.Widget.StackView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.StackView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.StackView.Views), nameof(SharpReact.Android.Props.StackView));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
