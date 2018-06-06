using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class HwndHost<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.HwndHost
		where TElement : System.Windows.Interop.HwndHost, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(Props?.MessageHook, null) && ReferenceEquals(nextProps.MessageHook, null))
			{
				Element.MessageHook -= nextProps.MessageHook;
			}
			if (ReferenceEquals(Props?.MessageHook, null) && !ReferenceEquals(nextProps.MessageHook, null))
			{
				Element.MessageHook += nextProps.MessageHook;
			}
			if (!ReferenceEquals(Props?.DpiChanged, null) && ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged -= nextProps.DpiChanged;
			}
			if (ReferenceEquals(Props?.DpiChanged, null) && !ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged += nextProps.DpiChanged;
			}
		}
	}
}
