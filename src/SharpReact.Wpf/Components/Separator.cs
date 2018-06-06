using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Separator<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.Separator
		where TElement : System.Windows.Controls.Separator, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
