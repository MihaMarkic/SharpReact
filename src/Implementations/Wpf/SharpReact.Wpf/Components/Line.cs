using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Line<TProps>: Shape<TProps, global::System.Windows.Shapes.Line>
		where TProps : Props.Line
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.X1.HasValue)
			{
				Element.X1 = nextProps.X1.Value.Value;
			}
			if (nextProps.Y1.HasValue)
			{
				Element.Y1 = nextProps.Y1.Value.Value;
			}
			if (nextProps.X2.HasValue)
			{
				Element.X2 = nextProps.X2.Value.Value;
			}
			if (nextProps.Y2.HasValue)
			{
				Element.Y2 = nextProps.Y2.Value.Value;
			}
		}
	}
}
