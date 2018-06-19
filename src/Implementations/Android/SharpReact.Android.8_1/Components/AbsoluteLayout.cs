using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class AbsoluteLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.AbsoluteLayout
		where TElement : global::Android.Widget.AbsoluteLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.AbsoluteLayout(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignAbsoluteLayoutProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
