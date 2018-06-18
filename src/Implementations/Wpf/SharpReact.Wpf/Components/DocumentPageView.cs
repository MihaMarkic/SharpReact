using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DocumentPageView<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.DocumentPageView
		where TElement : global::System.Windows.Controls.Primitives.DocumentPageView, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.DocumentPaginator.HasValue)
			{
				Element.DocumentPaginator = nextProps.DocumentPaginator.Value.Value;
			}
			if (nextProps.PageNumber.HasValue)
			{
				Element.PageNumber = nextProps.PageNumber.Value.Value;
			}
			if (nextProps.Stretch.HasValue)
			{
				Element.Stretch = nextProps.Stretch.Value.Value;
			}
			if (nextProps.StretchDirection.HasValue)
			{
				Element.StretchDirection = nextProps.StretchDirection.Value.Value;
			}
			if (!ReferenceEquals(previous?.PageConnected, null) && ReferenceEquals(nextProps.PageConnected, null))
			{
				Element.PageConnected -= nextProps.PageConnected;
			}
			if (ReferenceEquals(previous?.PageConnected, null) && !ReferenceEquals(nextProps.PageConnected, null))
			{
				Element.PageConnected += nextProps.PageConnected;
			}
			if (!ReferenceEquals(previous?.PageDisconnected, null) && ReferenceEquals(nextProps.PageDisconnected, null))
			{
				Element.PageDisconnected -= nextProps.PageDisconnected;
			}
			if (ReferenceEquals(previous?.PageDisconnected, null) && !ReferenceEquals(nextProps.PageDisconnected, null))
			{
				Element.PageDisconnected += nextProps.PageDisconnected;
			}
		}
	}
}
