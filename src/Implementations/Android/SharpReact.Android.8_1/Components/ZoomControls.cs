using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ZoomControls<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.ZoomControls
		where TElement : global::Android.Widget.ZoomControls
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ZoomControls(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignZoomControlsProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
