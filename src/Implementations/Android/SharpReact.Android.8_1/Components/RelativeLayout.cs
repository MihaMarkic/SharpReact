using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class RelativeLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.RelativeLayout
		where TElement : global::Android.Widget.RelativeLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.RelativeLayout(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.RelativeLayout.Views), nameof(SharpReact.Android.Props.RelativeLayout));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
