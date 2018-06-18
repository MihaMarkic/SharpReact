using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class VideoView<TProps, TElement>: SurfaceView<TProps, TElement>
		where TProps : Props.VideoView
		where TElement : global::Android.Widget.VideoView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.VideoView(context);
		}
	}
}
