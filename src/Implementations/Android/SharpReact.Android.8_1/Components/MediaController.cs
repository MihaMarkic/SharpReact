using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class MediaController<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.MediaController
		where TElement : global::Android.Widget.MediaController
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.MediaController(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignMediaControllerProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
