using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class GLSurfaceView: SurfaceView
	{
		public ReactParam<global::Android.Opengl.DebugFlags>? DebugFlags { get; set; }
		public ReactParam<global::System.Boolean>? PreserveEGLContextOnPause { get; set; }
		public ReactParam<global::Android.Opengl.Rendermode>? RenderMode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GLSurfaceView<GLSurfaceView, global::Android.Opengl.GLSurfaceView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return DebugFlags;
				yield return PreserveEGLContextOnPause;
				yield return RenderMode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
