using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class Button<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.Button
		where TElement : global::Android.Widget.Button
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Button(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignButtonProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
