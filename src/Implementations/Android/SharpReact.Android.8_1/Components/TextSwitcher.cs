using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TextSwitcher<TProps, TElement>: ViewSwitcher<TProps, TElement>
		where TProps : Props.TextSwitcher
		where TElement : global::Android.Widget.TextSwitcher
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TextSwitcher(context);
		}
	}
}
