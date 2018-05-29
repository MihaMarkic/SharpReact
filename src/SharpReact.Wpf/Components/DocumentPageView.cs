
namespace SharpReact.Wpf.Components
{
	public  class DocumentPageView<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.DocumentPageView
		where TElement : System.Windows.Controls.Primitives.DocumentPageView
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.DocumentPageView();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
			if (!ReferenceEquals(Props?.PageConnected, null) && ReferenceEquals(nextProps.PageConnected, null))
			{
				Element.PageConnected -= nextProps.PageConnected;
			}
			if (ReferenceEquals(Props?.PageConnected, null) && !ReferenceEquals(nextProps.PageConnected, null))
			{
				Element.PageConnected += nextProps.PageConnected;
			}
			if (!ReferenceEquals(Props?.PageDisconnected, null) && ReferenceEquals(nextProps.PageDisconnected, null))
			{
				Element.PageDisconnected -= nextProps.PageDisconnected;
			}
			if (ReferenceEquals(Props?.PageDisconnected, null) && !ReferenceEquals(nextProps.PageDisconnected, null))
			{
				Element.PageDisconnected += nextProps.PageDisconnected;
			}
		}
	}
}
