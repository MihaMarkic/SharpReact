using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TwoLineListItem<TProps, TElement>: RelativeLayout<TProps, TElement>
		where TProps : Props.TwoLineListItem
		where TElement : global::Android.Widget.TwoLineListItem
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TwoLineListItem(context);
		}
	}
}
