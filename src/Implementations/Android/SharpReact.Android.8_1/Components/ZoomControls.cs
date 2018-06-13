using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ZoomControls<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.ZoomControls
		where TElement : global::Android.Widget.ZoomControls
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ZoomControls(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.ZoomControls.Views), nameof(SharpReact.Android.Props.ZoomControls));
				ElementSynchronizer.SyncElements(Element, elements);
			}
			if (!ReferenceEquals(previous?.ZoomInClick, null) && ReferenceEquals(nextProps.ZoomInClick, null))
			{
				Element.ZoomInClick -= nextProps.ZoomInClick;
			}
			if (ReferenceEquals(previous?.ZoomInClick, null) && !ReferenceEquals(nextProps.ZoomInClick, null))
			{
				Element.ZoomInClick += nextProps.ZoomInClick;
			}
			if (!ReferenceEquals(previous?.ZoomOutClick, null) && ReferenceEquals(nextProps.ZoomOutClick, null))
			{
				Element.ZoomOutClick -= nextProps.ZoomOutClick;
			}
			if (ReferenceEquals(previous?.ZoomOutClick, null) && !ReferenceEquals(nextProps.ZoomOutClick, null))
			{
				Element.ZoomOutClick += nextProps.ZoomOutClick;
			}
		}
	}
}
