using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ImageSwitcher<TProps, TElement>: ViewSwitcher<TProps, TElement>
		where TProps : Props.ImageSwitcher
		where TElement : global::Android.Widget.ImageSwitcher
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ImageSwitcher(context);
		}
	}
}
