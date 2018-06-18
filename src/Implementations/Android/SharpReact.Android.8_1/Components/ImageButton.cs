using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ImageButton<TProps, TElement>: ImageView<TProps, TElement>
		where TProps : Props.ImageButton
		where TElement : global::Android.Widget.ImageButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ImageButton(context);
		}
	}
}
