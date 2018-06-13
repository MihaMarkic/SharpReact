using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ToolBarOverflowPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.ToolBarOverflowPanel
		where TElement : global::System.Windows.Controls.Primitives.ToolBarOverflowPanel, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.WrapWidth.HasValue)
			{
				Element.WrapWidth = nextProps.WrapWidth.Value.Value;
			}
		}
	}
}
