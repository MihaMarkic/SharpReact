using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class PagerTabStrip<TProps, TElement>: PagerTitleStrip<TProps, TElement>
		where TProps : Props.PagerTabStrip
		where TElement : global::Android.Support.V4.View.PagerTabStrip
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V4.View.PagerTabStrip(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdatePagerTabStripWithInstanceProperties(Element, previous, nextProps);
			PostAssignPagerTabStripProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignPagerTabStripProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdatePagerTabStripWithInstanceProperties(element, null, props);
		}
		static void UpdatePagerTabStripWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.DrawFullUnderline.HasValue)
			{
				element.DrawFullUnderline = nextProps.DrawFullUnderline.Value.Value;
			}
			if (nextProps.TabIndicatorColor.HasValue)
			{
				element.TabIndicatorColor = nextProps.TabIndicatorColor.Value.Value;
			}
		}
	}
}
