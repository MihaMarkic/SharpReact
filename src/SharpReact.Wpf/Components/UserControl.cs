using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class UserControl<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.UserControl
		where TElement : System.Windows.Controls.UserControl, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
