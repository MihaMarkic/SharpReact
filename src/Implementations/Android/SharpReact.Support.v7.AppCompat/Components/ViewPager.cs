using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class ViewPager<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.ViewPager
		where TElement : global::Android.Support.V4.View.ViewPager
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V4.View.ViewPager(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateViewPagerWithInstanceProperties(Element, previous, nextProps);
			PostAssignViewPagerProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignViewPagerProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateViewPagerWithInstanceProperties(element, null, props);
		}
		static void UpdateViewPagerWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Adapter.HasValue)
			{
				element.Adapter = nextProps.Adapter.Value.Value;
			}
			if (nextProps.CurrentItem.HasValue)
			{
				element.CurrentItem = nextProps.CurrentItem.Value.Value;
			}
			if (nextProps.OffscreenPageLimit.HasValue)
			{
				element.OffscreenPageLimit = nextProps.OffscreenPageLimit.Value.Value;
			}
			if (nextProps.PageMargin.HasValue)
			{
				element.PageMargin = nextProps.PageMargin.Value.Value;
			}
			if (!(previous?.AdapterChange is null) && nextProps.AdapterChange is null)
			{
				element.AdapterChange -= nextProps.AdapterChange;
			}
			if (previous?.AdapterChange is null && !(nextProps.AdapterChange is null))
			{
				element.AdapterChange += nextProps.AdapterChange;
			}
			if (!(previous?.PageScrollStateChanged is null) && nextProps.PageScrollStateChanged is null)
			{
				element.PageScrollStateChanged -= nextProps.PageScrollStateChanged;
			}
			if (previous?.PageScrollStateChanged is null && !(nextProps.PageScrollStateChanged is null))
			{
				element.PageScrollStateChanged += nextProps.PageScrollStateChanged;
			}
			if (!(previous?.PageScrolled is null) && nextProps.PageScrolled is null)
			{
				element.PageScrolled -= nextProps.PageScrolled;
			}
			if (previous?.PageScrolled is null && !(nextProps.PageScrolled is null))
			{
				element.PageScrolled += nextProps.PageScrolled;
			}
			if (!(previous?.PageSelected is null) && nextProps.PageSelected is null)
			{
				element.PageSelected -= nextProps.PageSelected;
			}
			if (previous?.PageSelected is null && !(nextProps.PageSelected is null))
			{
				element.PageSelected += nextProps.PageSelected;
			}
		}
	}
}
