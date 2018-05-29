
namespace SharpReact.Wpf.Components
{
	public  class GridSplitter<TProps, TElement>: Thumb<TProps, TElement>
		where TProps : Props.GridSplitter
		where TElement : System.Windows.Controls.GridSplitter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.GridSplitter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.ResizeDirection.HasValue)
			{
				Element.ResizeDirection = nextProps.ResizeDirection.Value.Value;
			}
			if (nextProps.ResizeBehavior.HasValue)
			{
				Element.ResizeBehavior = nextProps.ResizeBehavior.Value.Value;
			}
			if (nextProps.ShowsPreview.HasValue)
			{
				Element.ShowsPreview = nextProps.ShowsPreview.Value.Value;
			}
			if (nextProps.PreviewStyle.HasValue)
			{
				Element.PreviewStyle = nextProps.PreviewStyle.Value.Value;
			}
			if (nextProps.KeyboardIncrement.HasValue)
			{
				Element.KeyboardIncrement = nextProps.KeyboardIncrement.Value.Value;
			}
			if (nextProps.DragIncrement.HasValue)
			{
				Element.DragIncrement = nextProps.DragIncrement.Value.Value;
			}
		}
	}
}
