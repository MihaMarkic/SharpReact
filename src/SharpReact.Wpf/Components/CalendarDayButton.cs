using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class CalendarDayButton<TProps>: Button<TProps, global::System.Windows.Controls.Primitives.CalendarDayButton>
		where TProps : Props.CalendarDayButton
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
