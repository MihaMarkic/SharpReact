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
			UpdateTextureViewWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateTextureViewWithInstanceProperties(element, null, props);
		}
		static void UpdateTextureViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.SurfaceTexture.HasValue)
			{
				element.SurfaceTexture = nextProps.SurfaceTexture.Value.Value;
			}
			if (nextProps.SurfaceTextureListener.HasValue)
			{
				element.SurfaceTextureListener = nextProps.SurfaceTextureListener.Value.Value;
			}
			if (!(previous?.SurfaceTextureAvailable is null) && nextProps.SurfaceTextureAvailable is null)
			{
				element.SurfaceTextureAvailable -= nextProps.SurfaceTextureAvailable;
			}
			if (previous?.SurfaceTextureAvailable is null && !(nextProps.SurfaceTextureAvailable is null))
			{
				element.SurfaceTextureAvailable += nextProps.SurfaceTextureAvailable;
			}
			if (!(previous?.SurfaceTextureDestroyed is null) && nextProps.SurfaceTextureDestroyed is null)
			{
				element.SurfaceTextureDestroyed -= nextProps.SurfaceTextureDestroyed;
			}
			if (previous?.SurfaceTextureDestroyed is null && !(nextProps.SurfaceTextureDestroyed is null))
			{
				element.SurfaceTextureDestroyed += nextProps.SurfaceTextureDestroyed;
			}
			if (!(previous?.SurfaceTextureSizeChanged is null) && nextProps.SurfaceTextureSizeChanged is null)
			{
				element.SurfaceTextureSizeChanged -= nextProps.SurfaceTextureSizeChanged;
			}
			if (previous?.SurfaceTextureSizeChanged is null && !(nextProps.SurfaceTextureSizeChanged is null))
			{
				element.SurfaceTextureSizeChanged += nextProps.SurfaceTextureSizeChanged;
			}
			if (!(previous?.SurfaceTextureUpdated is null) && nextProps.SurfaceTextureUpdated is null)
			{
				element.SurfaceTextureUpdated -= nextProps.SurfaceTextureUpdated;
			}
			if (previous?.SurfaceTextureUpdated is null && !(nextProps.SurfaceTextureUpdated is null))
			{
				element.SurfaceTextureUpdated += nextProps.SurfaceTextureUpdated;
			}
		}
	}
}
