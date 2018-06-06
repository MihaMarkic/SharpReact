using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Path<TProps>: Shape<TProps, System.Windows.Shapes.Path>
		where TProps : Props.Path
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Data.HasValue)
			{
				Element.Data = nextProps.Data.Value.Value;
			}
		}
	}
}
