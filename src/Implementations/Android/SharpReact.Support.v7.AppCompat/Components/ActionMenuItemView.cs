using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class ActionMenuItemView<TProps, TElement>: AppCompatTextView<TProps, TElement>
		where TProps : Props.ActionMenuItemView
		where TElement : global::Android.Support.V7.View.Menu.ActionMenuItemView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.View.Menu.ActionMenuItemView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignActionMenuItemViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
