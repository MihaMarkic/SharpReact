using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ToolBarPanel<TProps, TElement>: StackPanel<TProps, TElement>
		where TProps : Props.ToolBarPanel
		where TElement : global::System.Windows.Controls.Primitives.ToolBarPanel, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
