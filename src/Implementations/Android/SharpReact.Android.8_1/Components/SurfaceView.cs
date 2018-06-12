using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class SurfaceView<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.SurfaceView
		where TElement : global::Android.Views.SurfaceView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
