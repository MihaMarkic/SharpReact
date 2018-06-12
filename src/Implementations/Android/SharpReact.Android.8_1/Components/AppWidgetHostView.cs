using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class AppWidgetHostView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.AppWidgetHostView
		where TElement : global::Android.Appwidget.AppWidgetHostView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
