using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class QuickContactBadge<TProps, TElement>: ImageView<TProps, TElement>
		where TProps : Props.QuickContactBadge
		where TElement : global::Android.Widget.QuickContactBadge
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.QuickContactBadge(context);
		}
	}
}
