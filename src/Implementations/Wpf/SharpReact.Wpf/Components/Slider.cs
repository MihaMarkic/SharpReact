using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Slider<TProps, TElement>: RangeBase<TProps, TElement>
		where TProps : Props.Slider
		where TElement : global::System.Windows.Controls.Slider, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.IsDirectionReversed.HasValue)
			{
				Element.IsDirectionReversed = nextProps.IsDirectionReversed.Value.Value;
			}
			if (nextProps.Delay.HasValue)
			{
				Element.Delay = nextProps.Delay.Value.Value;
			}
			if (nextProps.Interval.HasValue)
			{
				Element.Interval = nextProps.Interval.Value.Value;
			}
			if (nextProps.AutoToolTipPlacement.HasValue)
			{
				Element.AutoToolTipPlacement = nextProps.AutoToolTipPlacement.Value.Value;
			}
			if (nextProps.AutoToolTipPrecision.HasValue)
			{
				Element.AutoToolTipPrecision = nextProps.AutoToolTipPrecision.Value.Value;
			}
			if (nextProps.IsSnapToTickEnabled.HasValue)
			{
				Element.IsSnapToTickEnabled = nextProps.IsSnapToTickEnabled.Value.Value;
			}
			if (nextProps.TickPlacement.HasValue)
			{
				Element.TickPlacement = nextProps.TickPlacement.Value.Value;
			}
			if (nextProps.TickFrequency.HasValue)
			{
				Element.TickFrequency = nextProps.TickFrequency.Value.Value;
			}
			if (nextProps.Ticks.HasValue)
			{
				Element.Ticks = nextProps.Ticks.Value.Value;
			}
			if (nextProps.IsSelectionRangeEnabled.HasValue)
			{
				Element.IsSelectionRangeEnabled = nextProps.IsSelectionRangeEnabled.Value.Value;
			}
			if (nextProps.SelectionStart.HasValue)
			{
				Element.SelectionStart = nextProps.SelectionStart.Value.Value;
			}
			if (nextProps.SelectionEnd.HasValue)
			{
				Element.SelectionEnd = nextProps.SelectionEnd.Value.Value;
			}
			if (nextProps.IsMoveToPointEnabled.HasValue)
			{
				Element.IsMoveToPointEnabled = nextProps.IsMoveToPointEnabled.Value.Value;
			}
		}
	}
}
