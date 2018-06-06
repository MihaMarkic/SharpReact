using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class CalendarButton<TProps>: Button<TProps, System.Windows.Controls.Primitives.CalendarButton>
		where TProps : Props.CalendarButton
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
