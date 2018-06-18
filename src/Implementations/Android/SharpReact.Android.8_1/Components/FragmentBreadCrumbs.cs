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
	}
}
