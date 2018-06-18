using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class AbsoluteLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.AbsoluteLayout
		where TElement : global::Android.Widget.AbsoluteLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.AbsoluteLayout(context);
		}
	}
}
