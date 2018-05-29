
namespace SharpReact.Wpf.Components
{
	public  class CalendarDayButton<TProps>: Button<TProps, System.Windows.Controls.Primitives.CalendarDayButton>
		where TProps : Props.CalendarDayButton
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Controls.Primitives.CalendarDayButton();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
