using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class SwipeRefreshLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.SwipeRefreshLayout
		where TElement : global::Android.Support.V4.Widget.SwipeRefreshLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V4.Widget.SwipeRefreshLayout(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateSwipeRefreshLayoutWithInstanceProperties(Element, previous, nextProps);
			PostAssignSwipeRefreshLayoutProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignSwipeRefreshLayoutProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateSwipeRefreshLayoutWithInstanceProperties(element, null, props);
		}
		static void UpdateSwipeRefreshLayoutWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.NestedScrollingEnabled.HasValue)
			{
				element.NestedScrollingEnabled = nextProps.NestedScrollingEnabled.Value.Value;
			}
			if (nextProps.Refreshing.HasValue)
			{
				element.Refreshing = nextProps.Refreshing.Value.Value;
			}
			if (!(previous?.Refresh is null) && nextProps.Refresh is null)
			{
				element.Refresh -= nextProps.Refresh;
			}
			if (previous?.Refresh is null && !(nextProps.Refresh is null))
			{
				element.Refresh += nextProps.Refresh;
			}
		}
	}
}
