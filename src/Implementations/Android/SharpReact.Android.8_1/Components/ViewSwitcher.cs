using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ViewSwitcher<TProps, TElement>: ViewAnimator<TProps, TElement>
		where TProps : Props.ViewSwitcher
		where TElement : global::Android.Widget.ViewSwitcher
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ViewSwitcher(context);
		}
	}
}
