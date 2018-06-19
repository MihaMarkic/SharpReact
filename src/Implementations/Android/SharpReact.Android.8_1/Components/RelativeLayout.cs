using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class RelativeLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.RelativeLayout
		where TElement : global::Android.Widget.RelativeLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.RelativeLayout(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignRelativeLayoutProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
