using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class SurfaceView<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.SurfaceView
		where TElement : global::Android.Views.SurfaceView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Views.SurfaceView(context);
		}
	}
}
