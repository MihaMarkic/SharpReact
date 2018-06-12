using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class GridSplitter: Thumb
	{
		public ReactParam<global::System.Windows.Controls.GridResizeDirection>? ResizeDirection { get; set; }
		public ReactParam<global::System.Windows.Controls.GridResizeBehavior>? ResizeBehavior { get; set; }
		public ReactParam<global::System.Boolean>? ShowsPreview { get; set; }
		public ReactParam<global::System.Windows.Style>? PreviewStyle { get; set; }
		public ReactParam<global::System.Double>? KeyboardIncrement { get; set; }
		public ReactParam<global::System.Double>? DragIncrement { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GridSplitter<GridSplitter, System.Windows.Controls.GridSplitter>();
		}
	}
}
