using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class GLSurfaceView<TProps, TElement>: SurfaceView<TProps, TElement>
		where TProps : Props.GLSurfaceView
		where TElement : global::Android.Opengl.GLSurfaceView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Opengl.GLSurfaceView(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateGLSurfaceViewWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateGLSurfaceViewWithInstanceProperties(element, null, props);
		}
		static void UpdateGLSurfaceViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.DebugFlags.HasValue)
			{
				element.DebugFlags = nextProps.DebugFlags.Value.Value;
			}
			if (nextProps.PreserveEGLContextOnPause.HasValue)
			{
				element.PreserveEGLContextOnPause = nextProps.PreserveEGLContextOnPause.Value.Value;
			}
			if (nextProps.RenderMode.HasValue)
			{
				element.RenderMode = nextProps.RenderMode.Value.Value;
			}
		}
	}
}
