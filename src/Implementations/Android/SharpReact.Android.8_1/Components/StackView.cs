using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class StackView<TProps, TElement>: AdapterViewAnimator<TProps, TElement>
		where TProps : Props.StackView
		where TElement : global::Android.Widget.StackView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.StackView(context);
		}
	}
}
