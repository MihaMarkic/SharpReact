using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ExtractEditText<TProps, TElement>: EditText<TProps, TElement>
		where TProps : Props.ExtractEditText
		where TElement : global::Android.InputMethodServices.ExtractEditText
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.InputMethodServices.ExtractEditText(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignExtractEditTextProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
