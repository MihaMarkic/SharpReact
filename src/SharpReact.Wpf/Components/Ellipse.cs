using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Ellipse<TProps>: Shape<TProps, System.Windows.Shapes.Ellipse>
		where TProps : Props.Ellipse
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
