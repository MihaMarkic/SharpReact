using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class MediaRouteButton<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.MediaRouteButton
		where TElement : global::Android.App.MediaRouteButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.App.MediaRouteButton(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.RouteTypes.HasValue)
			{
				Element.RouteTypes = nextProps.RouteTypes.Value.Value;
			}
			if (!ReferenceEquals(previous?.ExtendedSettingsClick, null) && ReferenceEquals(nextProps.ExtendedSettingsClick, null))
			{
				Element.ExtendedSettingsClick -= nextProps.ExtendedSettingsClick;
			}
			if (ReferenceEquals(previous?.ExtendedSettingsClick, null) && !ReferenceEquals(nextProps.ExtendedSettingsClick, null))
			{
				Element.ExtendedSettingsClick += nextProps.ExtendedSettingsClick;
			}
		}
	}
}
