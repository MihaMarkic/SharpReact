using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class TwoLineListItem<TProps, TElement>: RelativeLayout<TProps, TElement>
		where TProps : Props.TwoLineListItem
		where TElement : global::Android.Widget.TwoLineListItem
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TwoLineListItem(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignTwoLineListItemProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
