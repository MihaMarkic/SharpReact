using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class PagerTitleStrip<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.PagerTitleStrip
		where TElement : global::Android.Support.V4.View.PagerTitleStrip
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V4.View.PagerTitleStrip(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdatePagerTitleStripWithInstanceProperties(Element, previous, nextProps);
			PostAssignPagerTitleStripProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignPagerTitleStripProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdatePagerTitleStripWithInstanceProperties(element, null, props);
		}
		static void UpdatePagerTitleStripWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.TextSpacing.HasValue)
			{
				element.TextSpacing = nextProps.TextSpacing.Value.Value;
			}
		}
	}
}
