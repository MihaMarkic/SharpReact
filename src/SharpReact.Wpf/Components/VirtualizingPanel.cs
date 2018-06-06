using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class VirtualizingPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.VirtualizingPanel
		where TElement : System.Windows.Controls.VirtualizingPanel, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
