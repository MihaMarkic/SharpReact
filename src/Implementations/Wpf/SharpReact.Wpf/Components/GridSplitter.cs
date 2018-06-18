using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class GridSplitter<TProps, TElement>: Thumb<TProps, TElement>
		where TProps : Props.GridSplitter
		where TElement : global::System.Windows.Controls.GridSplitter, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
