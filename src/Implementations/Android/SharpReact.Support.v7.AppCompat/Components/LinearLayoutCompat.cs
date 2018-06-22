using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class LinearLayoutCompat<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.LinearLayoutCompat
		where TElement : global::Android.Support.V7.Widget.LinearLayoutCompat
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.LinearLayoutCompat(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateLinearLayoutCompatWithInstanceProperties(Element, previous, nextProps);
			PostAssignLinearLayoutCompatProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignLinearLayoutCompatProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateLinearLayoutCompatWithInstanceProperties(element, null, props);
		}
		static void UpdateLinearLayoutCompatWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.BaselineAligned.HasValue)
			{
				element.BaselineAligned = nextProps.BaselineAligned.Value.Value;
			}
			if (nextProps.BaselineAlignedChildIndex.HasValue)
			{
				element.BaselineAlignedChildIndex = nextProps.BaselineAlignedChildIndex.Value.Value;
			}
			if (nextProps.DividerDrawable.HasValue)
			{
				element.DividerDrawable = nextProps.DividerDrawable.Value.Value;
			}
			if (nextProps.DividerPadding.HasValue)
			{
				element.DividerPadding = nextProps.DividerPadding.Value.Value;
			}
			if (nextProps.Gravity.HasValue)
			{
				element.Gravity = nextProps.Gravity.Value.Value;
			}
			if (nextProps.MeasureWithLargestChildEnabled.HasValue)
			{
				element.MeasureWithLargestChildEnabled = nextProps.MeasureWithLargestChildEnabled.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.ShowDividers.HasValue)
			{
				element.ShowDividers = nextProps.ShowDividers.Value.Value;
			}
			if (nextProps.WeightSum.HasValue)
			{
				element.WeightSum = nextProps.WeightSum.Value.Value;
			}
		}
	}
}
