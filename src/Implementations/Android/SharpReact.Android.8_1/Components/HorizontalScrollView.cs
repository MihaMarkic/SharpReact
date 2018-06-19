using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class HorizontalScrollView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.HorizontalScrollView
		where TElement : global::Android.Widget.HorizontalScrollView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.HorizontalScrollView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateHorizontalScrollViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignHorizontalScrollViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignHorizontalScrollViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateHorizontalScrollViewWithInstanceProperties(element, null, props);
		}
		static void UpdateHorizontalScrollViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.FillViewport.HasValue)
			{
				element.FillViewport = nextProps.FillViewport.Value.Value;
			}
			if (nextProps.SmoothScrollingEnabled.HasValue)
			{
				element.SmoothScrollingEnabled = nextProps.SmoothScrollingEnabled.Value.Value;
			}
		}
	}
}
