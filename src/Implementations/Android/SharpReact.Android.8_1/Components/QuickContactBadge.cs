using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class QuickContactBadge<TProps, TElement>: ImageView<TProps, TElement>
		where TProps : Props.QuickContactBadge
		where TElement : global::Android.Widget.QuickContactBadge
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.QuickContactBadge(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignQuickContactBadgeProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
