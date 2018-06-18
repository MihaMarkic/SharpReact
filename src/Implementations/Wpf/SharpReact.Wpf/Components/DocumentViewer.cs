using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DocumentViewer<TProps, TElement>: DocumentViewerBase<TProps, TElement>
		where TProps : Props.DocumentViewer
		where TElement : global::System.Windows.Controls.DocumentViewer, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
