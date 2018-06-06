using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class GridViewColumnHeader<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.GridViewColumnHeader
		where TElement : System.Windows.Controls.GridViewColumnHeader, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
