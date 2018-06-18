using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class RangeBase<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.RangeBase
		where TElement : global::System.Windows.Controls.Primitives.RangeBase, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Minimum.HasValue)
			{
				Element.Minimum = nextProps.Minimum.Value.Value;
			}
			if (nextProps.Maximum.HasValue)
			{
				Element.Maximum = nextProps.Maximum.Value.Value;
			}
			if (nextProps.Value.HasValue)
			{
				Element.Value = nextProps.Value.Value.Value;
			}
			if (nextProps.LargeChange.HasValue)
			{
				Element.LargeChange = nextProps.LargeChange.Value.Value;
			}
			if (nextProps.SmallChange.HasValue)
			{
				Element.SmallChange = nextProps.SmallChange.Value.Value;
			}
			if (!ReferenceEquals(previous?.ValueChanged, null) && ReferenceEquals(nextProps.ValueChanged, null))
			{
				Element.ValueChanged -= nextProps.ValueChanged;
			}
			if (ReferenceEquals(previous?.ValueChanged, null) && !ReferenceEquals(nextProps.ValueChanged, null))
			{
				Element.ValueChanged += nextProps.ValueChanged;
			}
		}
	}
}
