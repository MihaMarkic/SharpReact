using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class SlidingDrawer<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.SlidingDrawer
		where TElement : global::Android.Widget.SlidingDrawer
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(previous?.DrawerClose, null) && ReferenceEquals(nextProps.DrawerClose, null))
			{
				Element.DrawerClose -= nextProps.DrawerClose;
			}
			if (ReferenceEquals(previous?.DrawerClose, null) && !ReferenceEquals(nextProps.DrawerClose, null))
			{
				Element.DrawerClose += nextProps.DrawerClose;
			}
			if (!ReferenceEquals(previous?.DrawerOpen, null) && ReferenceEquals(nextProps.DrawerOpen, null))
			{
				Element.DrawerOpen -= nextProps.DrawerOpen;
			}
			if (ReferenceEquals(previous?.DrawerOpen, null) && !ReferenceEquals(nextProps.DrawerOpen, null))
			{
				Element.DrawerOpen += nextProps.DrawerOpen;
			}
			if (!ReferenceEquals(previous?.ScrollEnded, null) && ReferenceEquals(nextProps.ScrollEnded, null))
			{
				Element.ScrollEnded -= nextProps.ScrollEnded;
			}
			if (ReferenceEquals(previous?.ScrollEnded, null) && !ReferenceEquals(nextProps.ScrollEnded, null))
			{
				Element.ScrollEnded += nextProps.ScrollEnded;
			}
			if (!ReferenceEquals(previous?.ScrollStarted, null) && ReferenceEquals(nextProps.ScrollStarted, null))
			{
				Element.ScrollStarted -= nextProps.ScrollStarted;
			}
			if (ReferenceEquals(previous?.ScrollStarted, null) && !ReferenceEquals(nextProps.ScrollStarted, null))
			{
				Element.ScrollStarted += nextProps.ScrollStarted;
			}
		}
	}
}
