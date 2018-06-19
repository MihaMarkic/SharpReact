using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ImageSwitcher<TProps, TElement>: ViewSwitcher<TProps, TElement>
		where TProps : Props.ImageSwitcher
		where TElement : global::Android.Widget.ImageSwitcher
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ImageSwitcher(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignImageSwitcherProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
