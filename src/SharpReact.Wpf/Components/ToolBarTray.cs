using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ToolBarTray<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.ToolBarTray
		where TElement : global::System.Windows.Controls.ToolBarTray, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.IsLocked.HasValue)
			{
				Element.IsLocked = nextProps.IsLocked.Value.Value;
			}
		}
	}
}
