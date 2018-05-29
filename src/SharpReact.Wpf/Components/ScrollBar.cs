
namespace SharpReact.Wpf.Components
{
	public  class ScrollBar<TProps, TElement>: RangeBase<TProps, TElement>
		where TProps : Props.ScrollBar
		where TElement : System.Windows.Controls.Primitives.ScrollBar
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.ScrollBar();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.ViewportSize.HasValue)
			{
				Element.ViewportSize = nextProps.ViewportSize.Value.Value;
			}
			if (!ReferenceEquals(Props?.Scroll, null) && ReferenceEquals(nextProps.Scroll, null))
			{
				Element.Scroll -= nextProps.Scroll;
			}
			if (ReferenceEquals(Props?.Scroll, null) && !ReferenceEquals(nextProps.Scroll, null))
			{
				Element.Scroll += nextProps.Scroll;
			}
		}
	}
}
