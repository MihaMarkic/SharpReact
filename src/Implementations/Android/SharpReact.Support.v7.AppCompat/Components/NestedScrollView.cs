using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class NestedScrollView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.NestedScrollView
		where TElement : global::Android.Support.V4.Widget.NestedScrollView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V4.Widget.NestedScrollView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateNestedScrollViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignNestedScrollViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignNestedScrollViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateNestedScrollViewWithInstanceProperties(element, null, props);
		}
		static void UpdateNestedScrollViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.FillViewport.HasValue)
			{
				element.FillViewport = nextProps.FillViewport.Value.Value;
			}
			if (nextProps.SmoothScrollingEnabled.HasValue)
			{
				element.SmoothScrollingEnabled = nextProps.SmoothScrollingEnabled.Value.Value;
			}
			if (!(previous?.ScrollChange is null) && nextProps.ScrollChange is null)
			{
				element.ScrollChange -= nextProps.ScrollChange;
			}
			if (previous?.ScrollChange is null && !(nextProps.ScrollChange is null))
			{
				element.ScrollChange += nextProps.ScrollChange;
			}
		}
	}
}
