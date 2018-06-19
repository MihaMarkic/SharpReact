using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class AnalogClock<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.AnalogClock
		where TElement : global::Android.Widget.AnalogClock
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.AnalogClock(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignAnalogClockProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
