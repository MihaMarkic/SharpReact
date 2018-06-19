using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ImageButton<TProps, TElement>: ImageView<TProps, TElement>
		where TProps : Props.ImageButton
		where TElement : global::Android.Widget.ImageButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ImageButton(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignImageButtonProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
