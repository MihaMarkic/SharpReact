using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TextureView<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.TextureView
		where TElement : global::Android.Views.TextureView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Views.TextureView(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.SurfaceTexture.HasValue)
			{
				Element.SurfaceTexture = nextProps.SurfaceTexture.Value.Value;
			}
			if (nextProps.SurfaceTextureListener.HasValue)
			{
				Element.SurfaceTextureListener = nextProps.SurfaceTextureListener.Value.Value;
			}
			if (!ReferenceEquals(previous?.SurfaceTextureAvailable, null) && ReferenceEquals(nextProps.SurfaceTextureAvailable, null))
			{
				Element.SurfaceTextureAvailable -= nextProps.SurfaceTextureAvailable;
			}
			if (ReferenceEquals(previous?.SurfaceTextureAvailable, null) && !ReferenceEquals(nextProps.SurfaceTextureAvailable, null))
			{
				Element.SurfaceTextureAvailable += nextProps.SurfaceTextureAvailable;
			}
			if (!ReferenceEquals(previous?.SurfaceTextureDestroyed, null) && ReferenceEquals(nextProps.SurfaceTextureDestroyed, null))
			{
				Element.SurfaceTextureDestroyed -= nextProps.SurfaceTextureDestroyed;
			}
			if (ReferenceEquals(previous?.SurfaceTextureDestroyed, null) && !ReferenceEquals(nextProps.SurfaceTextureDestroyed, null))
			{
				Element.SurfaceTextureDestroyed += nextProps.SurfaceTextureDestroyed;
			}
			if (!ReferenceEquals(previous?.SurfaceTextureSizeChanged, null) && ReferenceEquals(nextProps.SurfaceTextureSizeChanged, null))
			{
				Element.SurfaceTextureSizeChanged -= nextProps.SurfaceTextureSizeChanged;
			}
			if (ReferenceEquals(previous?.SurfaceTextureSizeChanged, null) && !ReferenceEquals(nextProps.SurfaceTextureSizeChanged, null))
			{
				Element.SurfaceTextureSizeChanged += nextProps.SurfaceTextureSizeChanged;
			}
			if (!ReferenceEquals(previous?.SurfaceTextureUpdated, null) && ReferenceEquals(nextProps.SurfaceTextureUpdated, null))
			{
				Element.SurfaceTextureUpdated -= nextProps.SurfaceTextureUpdated;
			}
			if (ReferenceEquals(previous?.SurfaceTextureUpdated, null) && !ReferenceEquals(nextProps.SurfaceTextureUpdated, null))
			{
				Element.SurfaceTextureUpdated += nextProps.SurfaceTextureUpdated;
			}
		}
	}
}
