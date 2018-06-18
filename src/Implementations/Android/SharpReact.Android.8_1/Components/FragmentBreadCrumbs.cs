using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class FragmentBreadCrumbs<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.FragmentBreadCrumbs
		where TElement : global::Android.App.FragmentBreadCrumbs
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.App.FragmentBreadCrumbs(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(previous?.BreadCrumbClick, null) && ReferenceEquals(nextProps.BreadCrumbClick, null))
			{
				Element.BreadCrumbClick -= nextProps.BreadCrumbClick;
			}
			if (ReferenceEquals(previous?.BreadCrumbClick, null) && !ReferenceEquals(nextProps.BreadCrumbClick, null))
			{
				Element.BreadCrumbClick += nextProps.BreadCrumbClick;
			}
		}
	}
}
