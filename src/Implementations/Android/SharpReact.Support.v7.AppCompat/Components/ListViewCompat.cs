using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class ListViewCompat<TProps, TElement>: ListView<TProps, TElement>
		where TProps : Props.ListViewCompat
		where TElement : global::Android.Support.V7.Widget.ListViewCompat
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.ListViewCompat(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignListViewCompatProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
