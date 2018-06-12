using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class LinearLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.LinearLayout
		where TElement : global::Android.Widget.LinearLayout
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.BaselineAligned.HasValue)
			{
				Element.BaselineAligned = nextProps.BaselineAligned.Value.Value;
			}
			if (nextProps.BaselineAlignedChildIndex.HasValue)
			{
				Element.BaselineAlignedChildIndex = nextProps.BaselineAlignedChildIndex.Value.Value;
			}
			if (nextProps.DividerPadding.HasValue)
			{
				Element.DividerPadding = nextProps.DividerPadding.Value.Value;
			}
			if (nextProps.MeasureWithLargestChildEnabled.HasValue)
			{
				Element.MeasureWithLargestChildEnabled = nextProps.MeasureWithLargestChildEnabled.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.ShowDividers.HasValue)
			{
				Element.ShowDividers = nextProps.ShowDividers.Value.Value;
			}
			if (nextProps.WeightSum.HasValue)
			{
				Element.WeightSum = nextProps.WeightSum.Value.Value;
			}
		}
	}
}
