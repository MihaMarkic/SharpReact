using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class TickBar<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.TickBar
		where TElement : global::System.Windows.Controls.Primitives.TickBar, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Fill.HasValue)
			{
				Element.Fill = nextProps.Fill.Value.Value;
			}
			if (nextProps.Minimum.HasValue)
			{
				Element.Minimum = nextProps.Minimum.Value.Value;
			}
			if (nextProps.Maximum.HasValue)
			{
				Element.Maximum = nextProps.Maximum.Value.Value;
			}
			if (nextProps.SelectionStart.HasValue)
			{
				Element.SelectionStart = nextProps.SelectionStart.Value.Value;
			}
			if (nextProps.SelectionEnd.HasValue)
			{
				Element.SelectionEnd = nextProps.SelectionEnd.Value.Value;
			}
			if (nextProps.IsSelectionRangeEnabled.HasValue)
			{
				Element.IsSelectionRangeEnabled = nextProps.IsSelectionRangeEnabled.Value.Value;
			}
			if (nextProps.TickFrequency.HasValue)
			{
				Element.TickFrequency = nextProps.TickFrequency.Value.Value;
			}
			if (nextProps.Ticks.HasValue)
			{
				Element.Ticks = nextProps.Ticks.Value.Value;
			}
			if (nextProps.IsDirectionReversed.HasValue)
			{
				Element.IsDirectionReversed = nextProps.IsDirectionReversed.Value.Value;
			}
			if (nextProps.Placement.HasValue)
			{
				Element.Placement = nextProps.Placement.Value.Value;
			}
			if (nextProps.ReservedSpace.HasValue)
			{
				Element.ReservedSpace = nextProps.ReservedSpace.Value.Value;
			}
		}
	}
}
