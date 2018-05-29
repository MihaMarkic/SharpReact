
namespace SharpReact.Wpf.Components
{
	public  class RepeatButton<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.RepeatButton
		where TElement : System.Windows.Controls.Primitives.RepeatButton
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.RepeatButton();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Delay.HasValue)
			{
				Element.Delay = nextProps.Delay.Value.Value;
			}
			if (nextProps.Interval.HasValue)
			{
				Element.Interval = nextProps.Interval.Value.Value;
			}
		}
	}
}
