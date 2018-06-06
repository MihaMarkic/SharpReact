using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class RepeatButton<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.RepeatButton
		where TElement : System.Windows.Controls.Primitives.RepeatButton, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
