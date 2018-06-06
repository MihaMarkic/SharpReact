using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class InkCanvas<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.InkCanvas
		where TElement : System.Windows.Controls.InkCanvas, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.Strokes.HasValue)
			{
				Element.Strokes = nextProps.Strokes.Value.Value;
			}
			renderer.VisitAllCollection(level, newState, previous?.Children, nextProps.Children, Element.Children, nameof(Element.Children), nameof(SharpReact.Wpf.Props.InkCanvas));
			if (nextProps.DefaultDrawingAttributes.HasValue)
			{
				Element.DefaultDrawingAttributes = nextProps.DefaultDrawingAttributes.Value.Value;
			}
			if (nextProps.EraserShape.HasValue)
			{
				Element.EraserShape = nextProps.EraserShape.Value.Value;
			}
			if (nextProps.EditingMode.HasValue)
			{
				Element.EditingMode = nextProps.EditingMode.Value.Value;
			}
			if (nextProps.EditingModeInverted.HasValue)
			{
				Element.EditingModeInverted = nextProps.EditingModeInverted.Value.Value;
			}
			if (nextProps.UseCustomCursor.HasValue)
			{
				Element.UseCustomCursor = nextProps.UseCustomCursor.Value.Value;
			}
			if (nextProps.MoveEnabled.HasValue)
			{
				Element.MoveEnabled = nextProps.MoveEnabled.Value.Value;
			}
			if (nextProps.ResizeEnabled.HasValue)
			{
				Element.ResizeEnabled = nextProps.ResizeEnabled.Value.Value;
			}
			if (nextProps.DefaultStylusPointDescription.HasValue)
			{
				Element.DefaultStylusPointDescription = nextProps.DefaultStylusPointDescription.Value.Value;
			}
			if (nextProps.PreferredPasteFormats.HasValue)
			{
				Element.PreferredPasteFormats = nextProps.PreferredPasteFormats.Value.Value;
			}
			if (!ReferenceEquals(Props?.StrokeCollected, null) && ReferenceEquals(nextProps.StrokeCollected, null))
			{
				Element.StrokeCollected -= nextProps.StrokeCollected;
			}
			if (ReferenceEquals(Props?.StrokeCollected, null) && !ReferenceEquals(nextProps.StrokeCollected, null))
			{
				Element.StrokeCollected += nextProps.StrokeCollected;
			}
			if (!ReferenceEquals(Props?.Gesture, null) && ReferenceEquals(nextProps.Gesture, null))
			{
				Element.Gesture -= nextProps.Gesture;
			}
			if (ReferenceEquals(Props?.Gesture, null) && !ReferenceEquals(nextProps.Gesture, null))
			{
				Element.Gesture += nextProps.Gesture;
			}
			if (!ReferenceEquals(Props?.StrokesReplaced, null) && ReferenceEquals(nextProps.StrokesReplaced, null))
			{
				Element.StrokesReplaced -= nextProps.StrokesReplaced;
			}
			if (ReferenceEquals(Props?.StrokesReplaced, null) && !ReferenceEquals(nextProps.StrokesReplaced, null))
			{
				Element.StrokesReplaced += nextProps.StrokesReplaced;
			}
			if (!ReferenceEquals(Props?.DefaultDrawingAttributesReplaced, null) && ReferenceEquals(nextProps.DefaultDrawingAttributesReplaced, null))
			{
				Element.DefaultDrawingAttributesReplaced -= nextProps.DefaultDrawingAttributesReplaced;
			}
			if (ReferenceEquals(Props?.DefaultDrawingAttributesReplaced, null) && !ReferenceEquals(nextProps.DefaultDrawingAttributesReplaced, null))
			{
				Element.DefaultDrawingAttributesReplaced += nextProps.DefaultDrawingAttributesReplaced;
			}
			if (!ReferenceEquals(Props?.ActiveEditingModeChanged, null) && ReferenceEquals(nextProps.ActiveEditingModeChanged, null))
			{
				Element.ActiveEditingModeChanged -= nextProps.ActiveEditingModeChanged;
			}
			if (ReferenceEquals(Props?.ActiveEditingModeChanged, null) && !ReferenceEquals(nextProps.ActiveEditingModeChanged, null))
			{
				Element.ActiveEditingModeChanged += nextProps.ActiveEditingModeChanged;
			}
			if (!ReferenceEquals(Props?.EditingModeChanged, null) && ReferenceEquals(nextProps.EditingModeChanged, null))
			{
				Element.EditingModeChanged -= nextProps.EditingModeChanged;
			}
			if (ReferenceEquals(Props?.EditingModeChanged, null) && !ReferenceEquals(nextProps.EditingModeChanged, null))
			{
				Element.EditingModeChanged += nextProps.EditingModeChanged;
			}
			if (!ReferenceEquals(Props?.EditingModeInvertedChanged, null) && ReferenceEquals(nextProps.EditingModeInvertedChanged, null))
			{
				Element.EditingModeInvertedChanged -= nextProps.EditingModeInvertedChanged;
			}
			if (ReferenceEquals(Props?.EditingModeInvertedChanged, null) && !ReferenceEquals(nextProps.EditingModeInvertedChanged, null))
			{
				Element.EditingModeInvertedChanged += nextProps.EditingModeInvertedChanged;
			}
			if (!ReferenceEquals(Props?.SelectionMoving, null) && ReferenceEquals(nextProps.SelectionMoving, null))
			{
				Element.SelectionMoving -= nextProps.SelectionMoving;
			}
			if (ReferenceEquals(Props?.SelectionMoving, null) && !ReferenceEquals(nextProps.SelectionMoving, null))
			{
				Element.SelectionMoving += nextProps.SelectionMoving;
			}
			if (!ReferenceEquals(Props?.SelectionMoved, null) && ReferenceEquals(nextProps.SelectionMoved, null))
			{
				Element.SelectionMoved -= nextProps.SelectionMoved;
			}
			if (ReferenceEquals(Props?.SelectionMoved, null) && !ReferenceEquals(nextProps.SelectionMoved, null))
			{
				Element.SelectionMoved += nextProps.SelectionMoved;
			}
			if (!ReferenceEquals(Props?.StrokeErasing, null) && ReferenceEquals(nextProps.StrokeErasing, null))
			{
				Element.StrokeErasing -= nextProps.StrokeErasing;
			}
			if (ReferenceEquals(Props?.StrokeErasing, null) && !ReferenceEquals(nextProps.StrokeErasing, null))
			{
				Element.StrokeErasing += nextProps.StrokeErasing;
			}
			if (!ReferenceEquals(Props?.StrokeErased, null) && ReferenceEquals(nextProps.StrokeErased, null))
			{
				Element.StrokeErased -= nextProps.StrokeErased;
			}
			if (ReferenceEquals(Props?.StrokeErased, null) && !ReferenceEquals(nextProps.StrokeErased, null))
			{
				Element.StrokeErased += nextProps.StrokeErased;
			}
			if (!ReferenceEquals(Props?.SelectionResizing, null) && ReferenceEquals(nextProps.SelectionResizing, null))
			{
				Element.SelectionResizing -= nextProps.SelectionResizing;
			}
			if (ReferenceEquals(Props?.SelectionResizing, null) && !ReferenceEquals(nextProps.SelectionResizing, null))
			{
				Element.SelectionResizing += nextProps.SelectionResizing;
			}
			if (!ReferenceEquals(Props?.SelectionResized, null) && ReferenceEquals(nextProps.SelectionResized, null))
			{
				Element.SelectionResized -= nextProps.SelectionResized;
			}
			if (ReferenceEquals(Props?.SelectionResized, null) && !ReferenceEquals(nextProps.SelectionResized, null))
			{
				Element.SelectionResized += nextProps.SelectionResized;
			}
			if (!ReferenceEquals(Props?.SelectionChanging, null) && ReferenceEquals(nextProps.SelectionChanging, null))
			{
				Element.SelectionChanging -= nextProps.SelectionChanging;
			}
			if (ReferenceEquals(Props?.SelectionChanging, null) && !ReferenceEquals(nextProps.SelectionChanging, null))
			{
				Element.SelectionChanging += nextProps.SelectionChanging;
			}
			if (!ReferenceEquals(Props?.SelectionChanged, null) && ReferenceEquals(nextProps.SelectionChanged, null))
			{
				Element.SelectionChanged -= nextProps.SelectionChanged;
			}
			if (ReferenceEquals(Props?.SelectionChanged, null) && !ReferenceEquals(nextProps.SelectionChanged, null))
			{
				Element.SelectionChanged += nextProps.SelectionChanged;
			}
		}
	}
}
