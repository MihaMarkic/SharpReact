
namespace SharpReact.Wpf.Components
{
	public  class ProgressBar<TProps, TElement>: RangeBase<TProps, TElement>
		where TProps : Props.ProgressBar
		where TElement : System.Windows.Controls.ProgressBar
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ProgressBar();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsIndeterminate.HasValue)
			{
				Element.IsIndeterminate = nextProps.IsIndeterminate.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
		}
	}
}
