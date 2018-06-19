using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class VideoView<TProps, TElement>: SurfaceView<TProps, TElement>
		where TProps : Props.VideoView
		where TElement : global::Android.Widget.VideoView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.VideoView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignVideoViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
