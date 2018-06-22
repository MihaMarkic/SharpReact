using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class ActionBarOverlayLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.ActionBarOverlayLayout
		where TElement : global::Android.Support.V7.Widget.ActionBarOverlayLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.ActionBarOverlayLayout(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateActionBarOverlayLayoutWithInstanceProperties(Element, previous, nextProps);
			PostAssignActionBarOverlayLayoutProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignActionBarOverlayLayoutProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateActionBarOverlayLayoutWithInstanceProperties(element, null, props);
		}
		static void UpdateActionBarOverlayLayoutWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.ActionBarHideOffset.HasValue)
			{
				element.ActionBarHideOffset = nextProps.ActionBarHideOffset.Value.Value;
			}
			if (nextProps.HideOnContentScrollEnabled.HasValue)
			{
				element.HideOnContentScrollEnabled = nextProps.HideOnContentScrollEnabled.Value.Value;
			}
		}
	}
}
