using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ExpandableListView<TProps, TElement>: ListView<TProps, TElement>
		where TProps : Props.ExpandableListView
		where TElement : global::Android.Widget.ExpandableListView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ExpandableListView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignExpandableListViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
