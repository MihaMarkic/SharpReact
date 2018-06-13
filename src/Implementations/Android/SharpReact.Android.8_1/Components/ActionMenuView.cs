using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ActionMenuView<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.ActionMenuView
		where TElement : global::Android.Widget.ActionMenuView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ActionMenuView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.OverflowIcon.HasValue)
			{
				Element.OverflowIcon = nextProps.OverflowIcon.Value.Value;
			}
			if (nextProps.PopupTheme.HasValue)
			{
				Element.PopupTheme = nextProps.PopupTheme.Value.Value;
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
