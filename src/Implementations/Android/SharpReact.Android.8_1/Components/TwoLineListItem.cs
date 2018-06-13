using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TwoLineListItem<TProps, TElement>: RelativeLayout<TProps, TElement>
		where TProps : Props.TwoLineListItem
		where TElement : global::Android.Widget.TwoLineListItem
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TwoLineListItem(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.TwoLineListItem.Views), nameof(SharpReact.Android.Props.TwoLineListItem));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
