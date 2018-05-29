
namespace SharpReact.Wpf.Components
{
	public  class CalendarItem<TProps>: Control<TProps, System.Windows.Controls.Primitives.CalendarItem>
		where TProps : Props.CalendarItem
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Controls.Primitives.CalendarItem();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
