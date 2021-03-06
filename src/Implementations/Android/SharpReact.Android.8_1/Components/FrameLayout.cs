using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class FrameLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.FrameLayout
		where TElement : global::Android.Widget.FrameLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.FrameLayout(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateFrameLayoutWithInstanceProperties(Element, previous, nextProps);
			PostAssignFrameLayoutProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignFrameLayoutProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateFrameLayoutWithInstanceProperties(element, null, props);
		}
		static void UpdateFrameLayoutWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.MeasureAllChildren.HasValue)
			{
				element.MeasureAllChildren = nextProps.MeasureAllChildren.Value.Value;
			}
		}
	}
}
