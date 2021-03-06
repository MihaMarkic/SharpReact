using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class CalendarItem<TProps>: Control<TProps, global::System.Windows.Controls.Primitives.CalendarItem>
		where TProps : Props.CalendarItem
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
