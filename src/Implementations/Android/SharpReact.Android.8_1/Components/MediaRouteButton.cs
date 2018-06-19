using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class MediaRouteButton<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.MediaRouteButton
		where TElement : global::Android.App.MediaRouteButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.App.MediaRouteButton(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateMediaRouteButtonWithInstanceProperties(Element, previous, nextProps);
			PostAssignMediaRouteButtonProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignMediaRouteButtonProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateMediaRouteButtonWithInstanceProperties(element, null, props);
		}
		static void UpdateMediaRouteButtonWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.RouteTypes.HasValue)
			{
				element.RouteTypes = nextProps.RouteTypes.Value.Value;
			}
			if (!(previous?.ExtendedSettingsClick is null) && nextProps.ExtendedSettingsClick is null)
			{
				element.ExtendedSettingsClick -= nextProps.ExtendedSettingsClick;
			}
			if (previous?.ExtendedSettingsClick is null && !(nextProps.ExtendedSettingsClick is null))
			{
				element.ExtendedSettingsClick += nextProps.ExtendedSettingsClick;
			}
		}
	}
}
