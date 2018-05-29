
namespace SharpReact.Wpf.Components
{
	public  class DocumentViewer<TProps, TElement>: DocumentViewerBase<TProps, TElement>
		where TProps : Props.DocumentViewer
		where TElement : System.Windows.Controls.DocumentViewer
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.DocumentViewer();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.HorizontalOffset.HasValue)
			{
				Element.HorizontalOffset = nextProps.HorizontalOffset.Value.Value;
			}
			if (nextProps.VerticalOffset.HasValue)
			{
				Element.VerticalOffset = nextProps.VerticalOffset.Value.Value;
			}
			if (nextProps.ShowPageBorders.HasValue)
			{
				Element.ShowPageBorders = nextProps.ShowPageBorders.Value.Value;
			}
			if (nextProps.Zoom.HasValue)
			{
				Element.Zoom = nextProps.Zoom.Value.Value;
			}
			if (nextProps.MaxPagesAcross.HasValue)
			{
				Element.MaxPagesAcross = nextProps.MaxPagesAcross.Value.Value;
			}
			if (nextProps.VerticalPageSpacing.HasValue)
			{
				Element.VerticalPageSpacing = nextProps.VerticalPageSpacing.Value.Value;
			}
			if (nextProps.HorizontalPageSpacing.HasValue)
			{
				Element.HorizontalPageSpacing = nextProps.HorizontalPageSpacing.Value.Value;
			}
		}
	}
}
