using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Polygon<TProps>: Shape<TProps, System.Windows.Shapes.Polygon>
		where TProps : Props.Polygon
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Points.HasValue)
			{
				Element.Points = nextProps.Points.Value.Value;
			}
			if (nextProps.FillRule.HasValue)
			{
				Element.FillRule = nextProps.FillRule.Value.Value;
			}
		}
	}
}
