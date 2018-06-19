using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class RadioGroup<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.RadioGroup
		where TElement : global::Android.Widget.RadioGroup
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.RadioGroup(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignRadioGroupProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
