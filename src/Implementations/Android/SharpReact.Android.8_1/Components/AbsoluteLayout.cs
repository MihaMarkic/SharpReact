using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class AbsoluteLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.AbsoluteLayout
		where TElement : global::Android.Widget.AbsoluteLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.AbsoluteLayout(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.AbsoluteLayout.Views), nameof(SharpReact.Android.Props.AbsoluteLayout));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
