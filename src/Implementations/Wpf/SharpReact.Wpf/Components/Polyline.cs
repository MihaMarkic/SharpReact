using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Polyline<TProps>: Shape<TProps, global::System.Windows.Shapes.Polyline>
		where TProps : Props.Polyline
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
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
