using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class DigitalClock<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.DigitalClock
		where TElement : global::Android.Widget.DigitalClock
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.DigitalClock(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignDigitalClockProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
