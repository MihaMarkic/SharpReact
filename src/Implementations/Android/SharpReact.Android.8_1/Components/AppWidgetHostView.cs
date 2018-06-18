using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class AppWidgetHostView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.AppWidgetHostView
		where TElement : global::Android.Appwidget.AppWidgetHostView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Appwidget.AppWidgetHostView(context);
		}
	}
}
