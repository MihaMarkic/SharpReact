using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Canvas<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.Canvas
		where TElement : System.Windows.Controls.Canvas, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
