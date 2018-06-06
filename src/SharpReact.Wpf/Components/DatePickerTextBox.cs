using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DatePickerTextBox<TProps>: TextBox<TProps, System.Windows.Controls.Primitives.DatePickerTextBox>
		where TProps : Props.DatePickerTextBox
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
