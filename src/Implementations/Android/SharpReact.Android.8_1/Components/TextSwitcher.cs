using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class TextSwitcher<TProps, TElement>: ViewSwitcher<TProps, TElement>
		where TProps : Props.TextSwitcher
		where TElement : global::Android.Widget.TextSwitcher
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TextSwitcher(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignTextSwitcherProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
