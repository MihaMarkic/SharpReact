
namespace SharpReact.Wpf.Components
{
	public  class Track<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Track
		where TElement : System.Windows.Controls.Primitives.Track
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.Track();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.DecreaseRepeatButton.HasValue)
			{
				Element.DecreaseRepeatButton = nextProps.DecreaseRepeatButton.Value.Value;
			}
			if (nextProps.Thumb.HasValue)
			{
				Element.Thumb = nextProps.Thumb.Value.Value;
			}
			if (nextProps.IncreaseRepeatButton.HasValue)
			{
				Element.IncreaseRepeatButton = nextProps.IncreaseRepeatButton.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
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
			if (nextProps.ViewportSize.HasValue)
			{
				Element.ViewportSize = nextProps.ViewportSize.Value.Value;
			}
			if (nextProps.IsDirectionReversed.HasValue)
			{
				Element.IsDirectionReversed = nextProps.IsDirectionReversed.Value.Value;
			}
		}
	}
}
