using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class SlidingPaneLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.SlidingPaneLayout
		where TElement : global::Android.Support.V4.Widget.SlidingPaneLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V4.Widget.SlidingPaneLayout(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateSlidingPaneLayoutWithInstanceProperties(Element, previous, nextProps);
			PostAssignSlidingPaneLayoutProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignSlidingPaneLayoutProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateSlidingPaneLayoutWithInstanceProperties(element, null, props);
		}
		static void UpdateSlidingPaneLayoutWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.CoveredFadeColor.HasValue)
			{
				element.CoveredFadeColor = nextProps.CoveredFadeColor.Value.Value;
			}
			if (nextProps.ParallaxDistance.HasValue)
			{
				element.ParallaxDistance = nextProps.ParallaxDistance.Value.Value;
			}
			if (nextProps.SliderFadeColor.HasValue)
			{
				element.SliderFadeColor = nextProps.SliderFadeColor.Value.Value;
			}
			if (!(previous?.PanelClosed is null) && nextProps.PanelClosed is null)
			{
				element.PanelClosed -= nextProps.PanelClosed;
			}
			if (previous?.PanelClosed is null && !(nextProps.PanelClosed is null))
			{
				element.PanelClosed += nextProps.PanelClosed;
			}
			if (!(previous?.PanelOpened is null) && nextProps.PanelOpened is null)
			{
				element.PanelOpened -= nextProps.PanelOpened;
			}
			if (previous?.PanelOpened is null && !(nextProps.PanelOpened is null))
			{
				element.PanelOpened += nextProps.PanelOpened;
			}
			if (!(previous?.PanelSlide is null) && nextProps.PanelSlide is null)
			{
				element.PanelSlide -= nextProps.PanelSlide;
			}
			if (previous?.PanelSlide is null && !(nextProps.PanelSlide is null))
			{
				element.PanelSlide += nextProps.PanelSlide;
			}
		}
	}
}
