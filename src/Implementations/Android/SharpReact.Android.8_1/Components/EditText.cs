using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class EditText<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.EditText
		where TElement : global::Android.Widget.EditText
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.EditText(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignEditTextProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
