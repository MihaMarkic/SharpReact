using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class LinearLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.LinearLayout
		where TElement : global::Android.Widget.LinearLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.LinearLayout(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateLinearLayoutWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateLinearLayoutWithInstanceProperties(element, null, props);
		}
		static void UpdateLinearLayoutWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.BaselineAligned.HasValue)
			{
				element.BaselineAligned = nextProps.BaselineAligned.Value.Value;
			}
			if (nextProps.BaselineAlignedChildIndex.HasValue)
			{
				element.BaselineAlignedChildIndex = nextProps.BaselineAlignedChildIndex.Value.Value;
			}
			if (nextProps.DividerPadding.HasValue)
			{
				element.DividerPadding = nextProps.DividerPadding.Value.Value;
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
