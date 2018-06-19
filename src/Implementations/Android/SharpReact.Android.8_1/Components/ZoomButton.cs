using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ZoomButton<TProps, TElement>: ImageButton<TProps, TElement>
		where TProps : Props.ZoomButton
		where TElement : global::Android.Widget.ZoomButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ZoomButton(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignZoomButtonProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
