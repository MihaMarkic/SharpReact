using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class RSTextureView<TProps, TElement>: TextureView<TProps, TElement>
		where TProps : Props.RSTextureView
		where TElement : global::Android.Renderscripts.RSTextureView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Renderscripts.RSTextureView(context);
		}
	}
}
