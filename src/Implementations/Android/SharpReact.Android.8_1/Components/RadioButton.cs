using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class RadioButton<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.RadioButton
		where TElement : global::Android.Widget.RadioButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.RadioButton(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignRadioButtonProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
