using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ZoomButton<TProps, TElement>: ImageButton<TProps, TElement>
		where TProps : Props.ZoomButton
		where TElement : global::Android.Widget.ZoomButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ZoomButton(context);
		}
	}
}
