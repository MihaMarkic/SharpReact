
namespace SharpReact.Wpf.Components
{
	public  class TickBar<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.TickBar
		where TElement : System.Windows.Controls.Primitives.TickBar
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.TickBar();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
