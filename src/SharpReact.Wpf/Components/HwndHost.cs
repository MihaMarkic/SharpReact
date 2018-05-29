
namespace SharpReact.Wpf.Components
{
	public abstract class HwndHost<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.HwndHost
		where TElement : System.Windows.Interop.HwndHost
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
