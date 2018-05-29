
namespace SharpReact.Wpf.Components
{
	public abstract class RangeBase<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.RangeBase
		where TElement : System.Windows.Controls.Primitives.RangeBase
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
			if (!ReferenceEquals(Props?.ValueChanged, null) && ReferenceEquals(nextProps.ValueChanged, null))
			{
				Element.ValueChanged -= nextProps.ValueChanged;
			}
			if (ReferenceEquals(Props?.ValueChanged, null) && !ReferenceEquals(nextProps.ValueChanged, null))
			{
				Element.ValueChanged += nextProps.ValueChanged;
			}
		}
	}
}
