using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class InkCanvas<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.InkCanvas
		where TElement : global::System.Windows.Controls.InkCanvas, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
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
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Children, nextProps.Children, nameof(Element.Children), nameof(SharpReact.Wpf.Props.InkCanvas));
				ElementSynchronizer.SyncElements(Element.Children, elements);
			}
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
			if (!ReferenceEquals(previous?.StrokeCollected, null) && ReferenceEquals(nextProps.StrokeCollected, null))
			{
				Element.StrokeCollected -= nextProps.StrokeCollected;
			}
			if (ReferenceEquals(previous?.StrokeCollected, null) && !ReferenceEquals(nextProps.StrokeCollected, null))
			{
				Element.StrokeCollected += nextProps.StrokeCollected;
			}
			if (!ReferenceEquals(previous?.Gesture, null) && ReferenceEquals(nextProps.Gesture, null))
			{
				Element.Gesture -= nextProps.Gesture;
			}
			if (ReferenceEquals(previous?.Gesture, null) && !ReferenceEquals(nextProps.Gesture, null))
			{
				Element.Gesture += nextProps.Gesture;
			}
			if (!ReferenceEquals(previous?.StrokesReplaced, null) && ReferenceEquals(nextProps.StrokesReplaced, null))
			{
				Element.StrokesReplaced -= nextProps.StrokesReplaced;
			}
			if (ReferenceEquals(previous?.StrokesReplaced, null) && !ReferenceEquals(nextProps.StrokesReplaced, null))
			{
				Element.StrokesReplaced += nextProps.StrokesReplaced;
			}
			if (!ReferenceEquals(previous?.DefaultDrawingAttributesReplaced, null) && ReferenceEquals(nextProps.DefaultDrawingAttributesReplaced, null))
			{
				Element.DefaultDrawingAttributesReplaced -= nextProps.DefaultDrawingAttributesReplaced;
			}
			if (ReferenceEquals(previous?.DefaultDrawingAttributesReplaced, null) && !ReferenceEquals(nextProps.DefaultDrawingAttributesReplaced, null))
			{
				Element.DefaultDrawingAttributesReplaced += nextProps.DefaultDrawingAttributesReplaced;
			}
			if (!ReferenceEquals(previous?.ActiveEditingModeChanged, null) && ReferenceEquals(nextProps.ActiveEditingModeChanged, null))
			{
				Element.ActiveEditingModeChanged -= nextProps.ActiveEditingModeChanged;
			}
			if (ReferenceEquals(previous?.ActiveEditingModeChanged, null) && !ReferenceEquals(nextProps.ActiveEditingModeChanged, null))
			{
				Element.ActiveEditingModeChanged += nextProps.ActiveEditingModeChanged;
			}
			if (!ReferenceEquals(previous?.EditingModeChanged, null) && ReferenceEquals(nextProps.EditingModeChanged, null))
			{
				Element.EditingModeChanged -= nextProps.EditingModeChanged;
			}
			if (ReferenceEquals(previous?.EditingModeChanged, null) && !ReferenceEquals(nextProps.EditingModeChanged, null))
			{
				Element.EditingModeChanged += nextProps.EditingModeChanged;
			}
			if (!ReferenceEquals(previous?.EditingModeInvertedChanged, null) && ReferenceEquals(nextProps.EditingModeInvertedChanged, null))
			{
				Element.EditingModeInvertedChanged -= nextProps.EditingModeInvertedChanged;
			}
			if (ReferenceEquals(previous?.EditingModeInvertedChanged, null) && !ReferenceEquals(nextProps.EditingModeInvertedChanged, null))
			{
				Element.EditingModeInvertedChanged += nextProps.EditingModeInvertedChanged;
			}
			if (!ReferenceEquals(previous?.SelectionMoving, null) && ReferenceEquals(nextProps.SelectionMoving, null))
			{
				Element.SelectionMoving -= nextProps.SelectionMoving;
			}
			if (ReferenceEquals(previous?.SelectionMoving, null) && !ReferenceEquals(nextProps.SelectionMoving, null))
			{
				Element.SelectionMoving += nextProps.SelectionMoving;
			}
			if (!ReferenceEquals(previous?.SelectionMoved, null) && ReferenceEquals(nextProps.SelectionMoved, null))
			{
				Element.SelectionMoved -= nextProps.SelectionMoved;
			}
			if (ReferenceEquals(previous?.SelectionMoved, null) && !ReferenceEquals(nextProps.SelectionMoved, null))
			{
				Element.SelectionMoved += nextProps.SelectionMoved;
			}
			if (!ReferenceEquals(previous?.StrokeErasing, null) && ReferenceEquals(nextProps.StrokeErasing, null))
			{
				Element.StrokeErasing -= nextProps.StrokeErasing;
			}
			if (ReferenceEquals(previous?.StrokeErasing, null) && !ReferenceEquals(nextProps.StrokeErasing, null))
			{
				Element.StrokeErasing += nextProps.StrokeErasing;
			}
			if (!ReferenceEquals(previous?.StrokeErased, null) && ReferenceEquals(nextProps.StrokeErased, null))
			{
				Element.StrokeErased -= nextProps.StrokeErased;
			}
			if (ReferenceEquals(previous?.StrokeErased, null) && !ReferenceEquals(nextProps.StrokeErased, null))
			{
				Element.StrokeErased += nextProps.StrokeErased;
			}
			if (!ReferenceEquals(previous?.SelectionResizing, null) && ReferenceEquals(nextProps.SelectionResizing, null))
			{
				Element.SelectionResizing -= nextProps.SelectionResizing;
			}
			if (ReferenceEquals(previous?.SelectionResizing, null) && !ReferenceEquals(nextProps.SelectionResizing, null))
			{
				Element.SelectionResizing += nextProps.SelectionResizing;
			}
			if (!ReferenceEquals(previous?.SelectionResized, null) && ReferenceEquals(nextProps.SelectionResized, null))
			{
				Element.SelectionResized -= nextProps.SelectionResized;
			}
			if (ReferenceEquals(previous?.SelectionResized, null) && !ReferenceEquals(nextProps.SelectionResized, null))
			{
				Element.SelectionResized += nextProps.SelectionResized;
			}
			if (!ReferenceEquals(previous?.SelectionChanging, null) && ReferenceEquals(nextProps.SelectionChanging, null))
			{
				Element.SelectionChanging -= nextProps.SelectionChanging;
			}
			if (ReferenceEquals(previous?.SelectionChanging, null) && !ReferenceEquals(nextProps.SelectionChanging, null))
			{
				Element.SelectionChanging += nextProps.SelectionChanging;
			}
			if (!ReferenceEquals(previous?.SelectionChanged, null) && ReferenceEquals(nextProps.SelectionChanged, null))
			{
				Element.SelectionChanged -= nextProps.SelectionChanged;
			}
			if (ReferenceEquals(previous?.SelectionChanged, null) && !ReferenceEquals(nextProps.SelectionChanged, null))
			{
				Element.SelectionChanged += nextProps.SelectionChanged;
			}
		}
	}
}
