using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class InkCanvas: FrameworkElement
	{
		public ReactParam<System.Windows.Media.Brush>? Background { get; set; }
		public ReactParam<System.Windows.Ink.StrokeCollection>? Strokes { get; set; }
		public List<ISharpProp> Children { get; set; } = new List<ISharpProp>();
		public ReactParam<System.Windows.Ink.DrawingAttributes>? DefaultDrawingAttributes { get; set; }
		public ReactParam<System.Windows.Ink.StylusShape>? EraserShape { get; set; }
		public ReactParam<System.Windows.Controls.InkCanvasEditingMode>? EditingMode { get; set; }
		public ReactParam<System.Windows.Controls.InkCanvasEditingMode>? EditingModeInverted { get; set; }
		public ReactParam<System.Boolean>? UseCustomCursor { get; set; }
		public ReactParam<System.Boolean>? MoveEnabled { get; set; }
		public ReactParam<System.Boolean>? ResizeEnabled { get; set; }
		public ReactParam<System.Windows.Input.StylusPointDescription>? DefaultStylusPointDescription { get; set; }
		public ReactParam<System.Collections.Generic.IEnumerable<System.Windows.Controls.InkCanvasClipboardFormat>>? PreferredPasteFormats { get; set; }
		public System.Windows.Controls.InkCanvasStrokeCollectedEventHandler StrokeCollected { get; set; }
		public System.Windows.Controls.InkCanvasGestureEventHandler Gesture { get; set; }
		public System.Windows.Controls.InkCanvasStrokesReplacedEventHandler StrokesReplaced { get; set; }
		public System.Windows.Ink.DrawingAttributesReplacedEventHandler DefaultDrawingAttributesReplaced { get; set; }
		public System.Windows.RoutedEventHandler ActiveEditingModeChanged { get; set; }
		public System.Windows.RoutedEventHandler EditingModeChanged { get; set; }
		public System.Windows.RoutedEventHandler EditingModeInvertedChanged { get; set; }
		public System.Windows.Controls.InkCanvasSelectionEditingEventHandler SelectionMoving { get; set; }
		public System.EventHandler SelectionMoved { get; set; }
		public System.Windows.Controls.InkCanvasStrokeErasingEventHandler StrokeErasing { get; set; }
		public System.Windows.RoutedEventHandler StrokeErased { get; set; }
		public System.Windows.Controls.InkCanvasSelectionEditingEventHandler SelectionResizing { get; set; }
		public System.EventHandler SelectionResized { get; set; }
		public System.Windows.Controls.InkCanvasSelectionChangingEventHandler SelectionChanging { get; set; }
		public System.EventHandler SelectionChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.InkCanvas<InkCanvas, System.Windows.Controls.InkCanvas>();
		}
		protected override void UnmountComponent()
		{
			UnmountComponents(Children);
			base.UnmountComponent();
		}
	}
}
