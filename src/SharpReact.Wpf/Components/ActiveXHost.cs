using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class ActiveXHost<TProps, TElement>: HwndHost<TProps, TElement>
		where TProps : Props.ActiveXHost
		where TElement : System.Windows.Interop.ActiveXHost, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
