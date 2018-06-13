using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DockPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.DockPanel
		where TElement : global::System.Windows.Controls.DockPanel, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.LastChildFill.HasValue)
			{
				Element.LastChildFill = nextProps.LastChildFill.Value.Value;
			}
		}
	}
}
