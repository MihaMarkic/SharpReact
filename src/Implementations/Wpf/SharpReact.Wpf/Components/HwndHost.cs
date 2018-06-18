using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class HwndHost<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.HwndHost
		where TElement : global::System.Windows.Interop.HwndHost, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(previous?.MessageHook, null) && ReferenceEquals(nextProps.MessageHook, null))
			{
				Element.MessageHook -= nextProps.MessageHook;
			}
			if (ReferenceEquals(previous?.MessageHook, null) && !ReferenceEquals(nextProps.MessageHook, null))
			{
				Element.MessageHook += nextProps.MessageHook;
			}
			if (!ReferenceEquals(previous?.DpiChanged, null) && ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged -= nextProps.DpiChanged;
			}
			if (ReferenceEquals(previous?.DpiChanged, null) && !ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged += nextProps.DpiChanged;
			}
		}
	}
}
