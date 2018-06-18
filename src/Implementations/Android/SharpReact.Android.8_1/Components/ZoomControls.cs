using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ZoomControls<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.ZoomControls
		where TElement : global::Android.Widget.ZoomControls
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ZoomControls(context);
		}
	}
}
