using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class RSSurfaceView<TProps, TElement>: SurfaceView<TProps, TElement>
		where TProps : Props.RSSurfaceView
		where TElement : global::Android.Renderscripts.RSSurfaceView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Renderscripts.RSSurfaceView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
