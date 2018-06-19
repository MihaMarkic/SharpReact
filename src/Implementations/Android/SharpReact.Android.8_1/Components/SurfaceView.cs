using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class SurfaceView<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.SurfaceView
		where TElement : global::Android.Views.SurfaceView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Views.SurfaceView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignSurfaceViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
