using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TvView<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.TvView
		where TElement : global::Android.Media.TV.TvView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Media.TV.TvView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.TvView.Views), nameof(SharpReact.Android.Props.TvView));
				ElementSynchronizer.SyncElements(Element, elements);
			}
			if (!ReferenceEquals(previous?.UnhandledInputEvent, null) && ReferenceEquals(nextProps.UnhandledInputEvent, null))
			{
				Element.UnhandledInputEvent -= nextProps.UnhandledInputEvent;
			}
			if (ReferenceEquals(previous?.UnhandledInputEvent, null) && !ReferenceEquals(nextProps.UnhandledInputEvent, null))
			{
				Element.UnhandledInputEvent += nextProps.UnhandledInputEvent;
			}
		}
	}
}
