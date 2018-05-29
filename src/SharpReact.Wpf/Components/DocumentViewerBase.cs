
namespace SharpReact.Wpf.Components
{
	public abstract class DocumentViewerBase<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.DocumentViewerBase
		where TElement : System.Windows.Controls.Primitives.DocumentViewerBase
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Document.HasValue)
			{
				Element.Document = nextProps.Document.Value.Value;
			}
			if (!ReferenceEquals(Props?.PageViewsChanged, null) && ReferenceEquals(nextProps.PageViewsChanged, null))
			{
				Element.PageViewsChanged -= nextProps.PageViewsChanged;
			}
			if (ReferenceEquals(Props?.PageViewsChanged, null) && !ReferenceEquals(nextProps.PageViewsChanged, null))
			{
				Element.PageViewsChanged += nextProps.PageViewsChanged;
			}
		}
	}
}
