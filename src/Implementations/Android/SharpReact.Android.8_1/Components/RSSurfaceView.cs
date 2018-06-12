using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class RSSurfaceView<TProps, TElement>: SurfaceView<TProps, TElement>
		where TProps : Props.RSSurfaceView
		where TElement : global::Android.Renderscripts.RSSurfaceView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
