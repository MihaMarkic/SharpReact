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
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.LinearLayout.Views), nameof(SharpReact.Android.Props.LinearLayout));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
