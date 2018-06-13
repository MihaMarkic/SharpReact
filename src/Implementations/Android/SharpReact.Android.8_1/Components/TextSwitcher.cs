using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TextSwitcher<TProps, TElement>: ViewSwitcher<TProps, TElement>
		where TProps : Props.TextSwitcher
		where TElement : global::Android.Widget.TextSwitcher
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TextSwitcher(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.TextSwitcher.Views), nameof(SharpReact.Android.Props.TextSwitcher));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
