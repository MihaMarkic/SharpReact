using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class Button<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.Button
		where TElement : global::Android.Widget.Button
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Button(context);
		}
	}
}
