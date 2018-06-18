using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class TextureView: View
	{
		public ReactParam<global::Android.Graphics.SurfaceTexture>? SurfaceTexture { get; set; }
		public ReactParam<global::Android.Views.TextureView.ISurfaceTextureListener>? SurfaceTextureListener { get; set; }
		public System.EventHandler<global::Android.Views.TextureView.SurfaceTextureAvailableEventArgs> SurfaceTextureAvailable { get; set; }
		public System.EventHandler<global::Android.Views.TextureView.SurfaceTextureDestroyedEventArgs> SurfaceTextureDestroyed { get; set; }
		public System.EventHandler<global::Android.Views.TextureView.SurfaceTextureSizeChangedEventArgs> SurfaceTextureSizeChanged { get; set; }
		public System.EventHandler<global::Android.Views.TextureView.SurfaceTextureUpdatedEventArgs> SurfaceTextureUpdated { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TextureView<TextureView, global::Android.Views.TextureView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return SurfaceTexture;
				yield return SurfaceTextureListener;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
