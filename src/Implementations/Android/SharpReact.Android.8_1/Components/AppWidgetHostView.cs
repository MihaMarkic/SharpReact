using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class AppWidgetHostView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.AppWidgetHostView
		where TElement : global::Android.Appwidget.AppWidgetHostView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Appwidget.AppWidgetHostView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignAppWidgetHostViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
