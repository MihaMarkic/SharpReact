using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class CheckBox<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.CheckBox
		where TElement : global::Android.Widget.CheckBox
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.CheckBox(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignCheckBoxProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
