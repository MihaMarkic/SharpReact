using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ToolBarPanel<TProps, TElement>: StackPanel<TProps, TElement>
		where TProps : Props.ToolBarPanel
		where TElement : System.Windows.Controls.Primitives.ToolBarPanel, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
