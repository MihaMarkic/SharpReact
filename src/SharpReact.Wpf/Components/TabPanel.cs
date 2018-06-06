using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class TabPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.TabPanel
		where TElement : System.Windows.Controls.Primitives.TabPanel, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
