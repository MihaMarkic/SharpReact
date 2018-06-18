using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ExpandableListView<TProps, TElement>: ListView<TProps, TElement>
		where TProps : Props.ExpandableListView
		where TElement : global::Android.Widget.ExpandableListView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ExpandableListView(context);
		}
	}
}
