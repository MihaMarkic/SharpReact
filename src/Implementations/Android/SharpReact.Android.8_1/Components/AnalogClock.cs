using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class AnalogClock<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.AnalogClock
		where TElement : global::Android.Widget.AnalogClock
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.AnalogClock(context);
		}
	}
}
