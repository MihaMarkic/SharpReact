using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class Gallery<TProps, TElement>: AbsSpinner<TProps, TElement>
		where TProps : Props.Gallery
		where TElement : global::Android.Widget.Gallery
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Gallery(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignGalleryProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
