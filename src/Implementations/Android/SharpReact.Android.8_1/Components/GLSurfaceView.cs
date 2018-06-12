using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class GLSurfaceView<TProps, TElement>: SurfaceView<TProps, TElement>
		where TProps : Props.GLSurfaceView
		where TElement : global::Android.Opengl.GLSurfaceView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.DebugFlags.HasValue)
			{
				Element.DebugFlags = nextProps.DebugFlags.Value.Value;
			}
			if (nextProps.PreserveEGLContextOnPause.HasValue)
			{
				Element.PreserveEGLContextOnPause = nextProps.PreserveEGLContextOnPause.Value.Value;
			}
			if (nextProps.RenderMode.HasValue)
			{
				Element.RenderMode = nextProps.RenderMode.Value.Value;
			}
		}
	}
}
