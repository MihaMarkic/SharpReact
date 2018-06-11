using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ScrollBar<TProps, TElement>: RangeBase<TProps, TElement>
		where TProps : Props.ScrollBar
		where TElement : System.Windows.Controls.Primitives.ScrollBar, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.ViewportSize.HasValue)
			{
				Element.ViewportSize = nextProps.ViewportSize.Value.Value;
			}
			if (!ReferenceEquals(previous?.Scroll, null) && ReferenceEquals(nextProps.Scroll, null))
			{
				Element.Scroll -= nextProps.Scroll;
			}
			if (ReferenceEquals(previous?.Scroll, null) && !ReferenceEquals(nextProps.Scroll, null))
			{
				Element.Scroll += nextProps.Scroll;
			}
		}
	}
}
