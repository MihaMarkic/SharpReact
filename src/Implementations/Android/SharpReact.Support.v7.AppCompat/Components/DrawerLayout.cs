using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class DrawerLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.DrawerLayout
		where TElement : global::Android.Support.V4.Widget.DrawerLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V4.Widget.DrawerLayout(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateDrawerLayoutWithInstanceProperties(Element, previous, nextProps);
			PostAssignDrawerLayoutProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignDrawerLayoutProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateDrawerLayoutWithInstanceProperties(element, null, props);
		}
		static void UpdateDrawerLayoutWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.DrawerElevation.HasValue)
			{
				element.DrawerElevation = nextProps.DrawerElevation.Value.Value;
			}
			if (!(previous?.DrawerClosed is null) && nextProps.DrawerClosed is null)
			{
				element.DrawerClosed -= nextProps.DrawerClosed;
			}
			if (previous?.DrawerClosed is null && !(nextProps.DrawerClosed is null))
			{
				element.DrawerClosed += nextProps.DrawerClosed;
			}
			if (!(previous?.DrawerOpened is null) && nextProps.DrawerOpened is null)
			{
				element.DrawerOpened -= nextProps.DrawerOpened;
			}
			if (previous?.DrawerOpened is null && !(nextProps.DrawerOpened is null))
			{
				element.DrawerOpened += nextProps.DrawerOpened;
			}
			if (!(previous?.DrawerSlide is null) && nextProps.DrawerSlide is null)
			{
				element.DrawerSlide -= nextProps.DrawerSlide;
			}
			if (previous?.DrawerSlide is null && !(nextProps.DrawerSlide is null))
			{
				element.DrawerSlide += nextProps.DrawerSlide;
			}
			if (!(previous?.DrawerStateChanged is null) && nextProps.DrawerStateChanged is null)
			{
				element.DrawerStateChanged -= nextProps.DrawerStateChanged;
			}
			if (previous?.DrawerStateChanged is null && !(nextProps.DrawerStateChanged is null))
			{
				element.DrawerStateChanged += nextProps.DrawerStateChanged;
			}
		}
	}
}
