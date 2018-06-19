using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ViewSwitcher<TProps, TElement>: ViewAnimator<TProps, TElement>
		where TProps : Props.ViewSwitcher
		where TElement : global::Android.Widget.ViewSwitcher
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ViewSwitcher(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignViewSwitcherProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
