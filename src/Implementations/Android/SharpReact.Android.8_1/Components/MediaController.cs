using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class MediaController<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.MediaController
		where TElement : global::Android.Widget.MediaController
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.MediaController(context);
		}
	}
}
