using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class GroupBox<TProps, TElement>: HeaderedContentControl<TProps, TElement>
		where TProps : Props.GroupBox
		where TElement : System.Windows.Controls.GroupBox, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
