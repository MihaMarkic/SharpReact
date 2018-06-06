using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Menu<TProps, TElement>: MenuBase<TProps, TElement>
		where TProps : Props.Menu
		where TElement : System.Windows.Controls.Menu, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.IsMainMenu.HasValue)
			{
				Element.IsMainMenu = nextProps.IsMainMenu.Value.Value;
			}
		}
	}
}
