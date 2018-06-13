using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class Toolbar<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.Toolbar
		where TElement : global::Android.Widget.Toolbar
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Toolbar(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ContentInsetEndWithActions.HasValue)
			{
				Element.ContentInsetEndWithActions = nextProps.ContentInsetEndWithActions.Value.Value;
			}
			if (nextProps.ContentInsetStartWithNavigation.HasValue)
			{
				Element.ContentInsetStartWithNavigation = nextProps.ContentInsetStartWithNavigation.Value.Value;
			}
			if (nextProps.Logo.HasValue)
			{
				Element.Logo = nextProps.Logo.Value.Value;
			}
			if (nextProps.LogoDescriptionFormatted.HasValue)
			{
				Element.LogoDescriptionFormatted = nextProps.LogoDescriptionFormatted.Value.Value;
			}
			if (nextProps.LogoDescription.HasValue)
			{
				Element.LogoDescription = nextProps.LogoDescription.Value.Value;
			}
			if (nextProps.NavigationContentDescriptionFormatted.HasValue)
			{
				Element.NavigationContentDescriptionFormatted = nextProps.NavigationContentDescriptionFormatted.Value.Value;
			}
			if (nextProps.NavigationContentDescription.HasValue)
			{
				Element.NavigationContentDescription = nextProps.NavigationContentDescription.Value.Value;
			}
			if (nextProps.NavigationIcon.HasValue)
			{
				Element.NavigationIcon = nextProps.NavigationIcon.Value.Value;
			}
			if (nextProps.OverflowIcon.HasValue)
			{
				Element.OverflowIcon = nextProps.OverflowIcon.Value.Value;
			}
			if (nextProps.PopupTheme.HasValue)
			{
				Element.PopupTheme = nextProps.PopupTheme.Value.Value;
			}
			if (nextProps.SubtitleFormatted.HasValue)
			{
				Element.SubtitleFormatted = nextProps.SubtitleFormatted.Value.Value;
			}
			if (nextProps.Subtitle.HasValue)
			{
				Element.Subtitle = nextProps.Subtitle.Value.Value;
			}
			if (nextProps.TitleFormatted.HasValue)
			{
				Element.TitleFormatted = nextProps.TitleFormatted.Value.Value;
			}
			if (nextProps.Title.HasValue)
			{
				Element.Title = nextProps.Title.Value.Value;
			}
			if (nextProps.TitleMarginBottom.HasValue)
			{
				Element.TitleMarginBottom = nextProps.TitleMarginBottom.Value.Value;
			}
			if (nextProps.TitleMarginEnd.HasValue)
			{
				Element.TitleMarginEnd = nextProps.TitleMarginEnd.Value.Value;
			}
			if (nextProps.TitleMarginStart.HasValue)
			{
				Element.TitleMarginStart = nextProps.TitleMarginStart.Value.Value;
			}
			if (nextProps.TitleMarginTop.HasValue)
			{
				Element.TitleMarginTop = nextProps.TitleMarginTop.Value.Value;
			}
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.Toolbar.Views), nameof(SharpReact.Android.Props.Toolbar));
				ElementSynchronizer.SyncElements(Element, elements);
			}
			if (!ReferenceEquals(previous?.NavigationOnClick, null) && ReferenceEquals(nextProps.NavigationOnClick, null))
			{
				Element.NavigationOnClick -= nextProps.NavigationOnClick;
			}
			if (ReferenceEquals(previous?.NavigationOnClick, null) && !ReferenceEquals(nextProps.NavigationOnClick, null))
			{
				Element.NavigationOnClick += nextProps.NavigationOnClick;
			}
			if (!ReferenceEquals(previous?.MenuItemClick, null) && ReferenceEquals(nextProps.MenuItemClick, null))
			{
				Element.MenuItemClick -= nextProps.MenuItemClick;
			}
			if (ReferenceEquals(previous?.MenuItemClick, null) && !ReferenceEquals(nextProps.MenuItemClick, null))
			{
				Element.MenuItemClick += nextProps.MenuItemClick;
			}
		}
	}
}
