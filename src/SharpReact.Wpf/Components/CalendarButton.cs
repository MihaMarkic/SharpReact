
namespace SharpReact.Wpf.Components
{
	public  class CalendarButton<TProps>: Button<TProps, System.Windows.Controls.Primitives.CalendarButton>
		where TProps : Props.CalendarButton
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Controls.Primitives.CalendarButton();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
