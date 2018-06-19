using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class StackView<TProps, TElement>: AdapterViewAnimator<TProps, TElement>
		where TProps : Props.StackView
		where TElement : global::Android.Widget.StackView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.StackView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignStackViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
