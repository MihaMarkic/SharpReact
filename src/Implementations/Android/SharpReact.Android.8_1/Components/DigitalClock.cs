using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class DigitalClock<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.DigitalClock
		where TElement : global::Android.Widget.DigitalClock
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.DigitalClock(context);
		}
	}
}
