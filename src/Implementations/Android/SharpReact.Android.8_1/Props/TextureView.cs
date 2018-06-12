using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class TextureView: View
	{
		public ReactParam<global::Android.Graphics.SurfaceTexture>? SurfaceTexture { get; set; }
		public ReactParam<global::Android.Views.TextureView.ISurfaceTextureListener>? SurfaceTextureListener { get; set; }
		public System.EventHandler<global::Android.Views.TextureView.SurfaceTextureAvailableEventArgs> SurfaceTextureAvailable { get; set; }
		public System.EventHandler<global::Android.Views.TextureView.SurfaceTextureDestroyedEventArgs> SurfaceTextureDestroyed { get; set; }
		public System.EventHandler<global::Android.Views.TextureView.SurfaceTextureSizeChangedEventArgs> SurfaceTextureSizeChanged { get; set; }
		public System.EventHandler<global::Android.Views.TextureView.SurfaceTextureUpdatedEventArgs> SurfaceTextureUpdated { get; set; }
	}
}
