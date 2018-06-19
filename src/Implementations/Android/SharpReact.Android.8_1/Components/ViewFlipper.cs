using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ViewFlipper<TProps, TElement>: ViewAnimator<TProps, TElement>
		where TProps : Props.ViewFlipper
		where TElement : global::Android.Widget.ViewFlipper
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ViewFlipper(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateViewFlipperWithInstanceProperties(Element, previous, nextProps);
			PostAssignViewFlipperProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignViewFlipperProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateViewFlipperWithInstanceProperties(element, null, props);
		}
		static void UpdateViewFlipperWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.AutoStart.HasValue)
			{
				element.AutoStart = nextProps.AutoStart.Value.Value;
			}
		}
	}
}
