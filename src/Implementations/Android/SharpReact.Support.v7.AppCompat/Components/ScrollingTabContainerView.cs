using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class ScrollingTabContainerView<TProps, TElement>: HorizontalScrollView<TProps, TElement>
		where TProps : Props.ScrollingTabContainerView
		where TElement : global::Android.Support.V7.Widget.ScrollingTabContainerView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.ScrollingTabContainerView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignScrollingTabContainerViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
