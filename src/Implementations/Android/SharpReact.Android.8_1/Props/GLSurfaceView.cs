using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class GLSurfaceView: SurfaceView
	{
		public ReactParam<global::Android.Opengl.DebugFlags>? DebugFlags { get; set; }
		public ReactParam<global::System.Boolean>? PreserveEGLContextOnPause { get; set; }
		public ReactParam<global::Android.Opengl.Rendermode>? RenderMode { get; set; }
	}
}
