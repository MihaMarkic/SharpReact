using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class FragmentBreadCrumbs<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.FragmentBreadCrumbs
		where TElement : global::Android.App.FragmentBreadCrumbs
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.App.FragmentBreadCrumbs(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignFragmentBreadCrumbsProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
