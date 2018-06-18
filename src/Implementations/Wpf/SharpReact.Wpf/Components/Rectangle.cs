using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Rectangle<TProps>: Shape<TProps, global::System.Windows.Shapes.Rectangle>
		where TProps : Props.Rectangle
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.RadiusX.HasValue)
			{
				Element.RadiusX = nextProps.RadiusX.Value.Value;
			}
			if (nextProps.RadiusY.HasValue)
			{
				Element.RadiusY = nextProps.RadiusY.Value.Value;
			}
		}
	}
}
