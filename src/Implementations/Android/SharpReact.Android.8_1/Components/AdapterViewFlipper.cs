using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class AdapterViewFlipper<TProps, TElement>: AdapterViewAnimator<TProps, TElement>
		where TProps : Props.AdapterViewFlipper
		where TElement : global::Android.Widget.AdapterViewFlipper
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.AdapterViewFlipper(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAdapterViewFlipperWithInstanceProperties(Element, previous, nextProps);
			PostAssignAdapterViewFlipperProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAdapterViewFlipperProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAdapterViewFlipperWithInstanceProperties(element, null, props);
		}
		static void UpdateAdapterViewFlipperWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.AutoStart.HasValue)
			{
				element.AutoStart = nextProps.AutoStart.Value.Value;
			}
		}
	}
}
