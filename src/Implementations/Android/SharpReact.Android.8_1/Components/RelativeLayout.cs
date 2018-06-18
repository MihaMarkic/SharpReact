using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class RelativeLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.RelativeLayout
		where TElement : global::Android.Widget.RelativeLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.RelativeLayout(context);
		}
	}
}
