using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class RSSurfaceView<TProps, TElement>: SurfaceView<TProps, TElement>
		where TProps : Props.RSSurfaceView
		where TElement : global::Android.Renderscripts.RSSurfaceView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Renderscripts.RSSurfaceView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignRSSurfaceViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
