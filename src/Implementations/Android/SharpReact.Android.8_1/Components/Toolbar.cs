using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class Toolbar<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.Toolbar
		where TElement : global::Android.Widget.Toolbar
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Toolbar(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateToolbarWithInstanceProperties(Element, previous, nextProps);
			PostAssignToolbarProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignToolbarProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateToolbarWithInstanceProperties(element, null, props);
		}
		static void UpdateToolbarWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.ContentInsetEndWithActions.HasValue)
			{
				element.ContentInsetEndWithActions = nextProps.ContentInsetEndWithActions.Value.Value;
			}
			if (nextProps.ContentInsetStartWithNavigation.HasValue)
			{
				element.ContentInsetStartWithNavigation = nextProps.ContentInsetStartWithNavigation.Value.Value;
			}
			if (nextProps.Logo.HasValue)
			{
				element.Logo = nextProps.Logo.Value.Value;
			}
			if (nextProps.LogoDescriptionFormatted.HasValue)
			{
				element.LogoDescriptionFormatted = nextProps.LogoDescriptionFormatted.Value.Value;
			}
			if (nextProps.LogoDescription.HasValue)
			{
				element.LogoDescription = nextProps.LogoDescription.Value.Value;
			}
			if (nextProps.NavigationContentDescriptionFormatted.HasValue)
			{
				element.NavigationContentDescriptionFormatted = nextProps.NavigationContentDescriptionFormatted.Value.Value;
			}
			if (nextProps.NavigationContentDescription.HasValue)
			{
				element.NavigationContentDescription = nextProps.NavigationContentDescription.Value.Value;
			}
			if (nextProps.NavigationIcon.HasValue)
			{
				element.NavigationIcon = nextProps.NavigationIcon.Value.Value;
			}
			if (nextProps.OverflowIcon.HasValue)
			{
				element.OverflowIcon = nextProps.OverflowIcon.Value.Value;
			}
			if (nextProps.PopupTheme.HasValue)
			{
				element.PopupTheme = nextProps.PopupTheme.Value.Value;
			}
			if (nextProps.SubtitleFormatted.HasValue)
			{
				element.SubtitleFormatted = nextProps.SubtitleFormatted.Value.Value;
			}
			if (nextProps.Subtitle.HasValue)
			{
				element.Subtitle = nextProps.Subtitle.Value.Value;
			}
			if (nextProps.TitleFormatted.HasValue)
			{
				element.TitleFormatted = nextProps.TitleFormatted.Value.Value;
			}
			if (nextProps.Title.HasValue)
			{
				element.Title = nextProps.Title.Value.Value;
			}
			if (nextProps.TitleMarginBottom.HasValue)
			{
				element.TitleMarginBottom = nextProps.TitleMarginBottom.Value.Value;
			}
			if (nextProps.TitleMarginEnd.HasValue)
			{
				element.TitleMarginEnd = nextProps.TitleMarginEnd.Value.Value;
			}
			if (nextProps.TitleMarginStart.HasValue)
			{
				element.TitleMarginStart = nextProps.TitleMarginStart.Value.Value;
			}
			if (nextProps.TitleMarginTop.HasValue)
			{
				element.TitleMarginTop = nextProps.TitleMarginTop.Value.Value;
			}
			if (!(previous?.NavigationOnClick is null) && nextProps.NavigationOnClick is null)
			{
				element.NavigationOnClick -= nextProps.NavigationOnClick;
			}
			if (previous?.NavigationOnClick is null && !(nextProps.NavigationOnClick is null))
			{
				element.NavigationOnClick += nextProps.NavigationOnClick;
			}
			if (!(previous?.MenuItemClick is null) && nextProps.MenuItemClick is null)
			{
				element.MenuItemClick -= nextProps.MenuItemClick;
			}
			if (previous?.MenuItemClick is null && !(nextProps.MenuItemClick is null))
			{
				element.MenuItemClick += nextProps.MenuItemClick;
			}
		}
	}
}
