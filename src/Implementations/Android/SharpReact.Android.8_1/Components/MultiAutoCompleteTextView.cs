using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class MultiAutoCompleteTextView<TProps, TElement>: AutoCompleteTextView<TProps, TElement>
		where TProps : Props.MultiAutoCompleteTextView
		where TElement : global::Android.Widget.MultiAutoCompleteTextView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.MultiAutoCompleteTextView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignMultiAutoCompleteTextViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
