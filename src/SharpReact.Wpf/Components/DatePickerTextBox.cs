
namespace SharpReact.Wpf.Components
{
	public  class DatePickerTextBox<TProps>: TextBox<TProps, System.Windows.Controls.Primitives.DatePickerTextBox>
		where TProps : Props.DatePickerTextBox
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Controls.Primitives.DatePickerTextBox();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
