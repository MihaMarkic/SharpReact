using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class ActionMenuView<TProps, TElement>: LinearLayoutCompat<TProps, TElement>
		where TProps : Props.ActionMenuView
		where TElement : global::Android.Support.V7.Widget.ActionMenuView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.ActionMenuView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateActionMenuViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignActionMenuViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignActionMenuViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateActionMenuViewWithInstanceProperties(element, null, props);
		}
		static void UpdateActionMenuViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.OverflowIcon.HasValue)
			{
				element.OverflowIcon = nextProps.OverflowIcon.Value.Value;
			}
			if (nextProps.OverflowReserved.HasValue)
			{
				element.OverflowReserved = nextProps.OverflowReserved.Value.Value;
			}
			if (nextProps.PopupTheme.HasValue)
			{
				element.PopupTheme = nextProps.PopupTheme.Value.Value;
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
