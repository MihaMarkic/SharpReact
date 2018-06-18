using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class TextBoxBase<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.TextBoxBase
		where TElement : global::System.Windows.Controls.Primitives.TextBoxBase, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.IsReadOnly.HasValue)
			{
				Element.IsReadOnly = nextProps.IsReadOnly.Value.Value;
			}
			if (nextProps.IsReadOnlyCaretVisible.HasValue)
			{
				Element.IsReadOnlyCaretVisible = nextProps.IsReadOnlyCaretVisible.Value.Value;
			}
			if (nextProps.AcceptsReturn.HasValue)
			{
				Element.AcceptsReturn = nextProps.AcceptsReturn.Value.Value;
			}
			if (nextProps.AcceptsTab.HasValue)
			{
				Element.AcceptsTab = nextProps.AcceptsTab.Value.Value;
			}
			if (nextProps.HorizontalScrollBarVisibility.HasValue)
			{
				Element.HorizontalScrollBarVisibility = nextProps.HorizontalScrollBarVisibility.Value.Value;
			}
			if (nextProps.VerticalScrollBarVisibility.HasValue)
			{
				Element.VerticalScrollBarVisibility = nextProps.VerticalScrollBarVisibility.Value.Value;
			}
			if (nextProps.IsUndoEnabled.HasValue)
			{
				Element.IsUndoEnabled = nextProps.IsUndoEnabled.Value.Value;
			}
			if (nextProps.UndoLimit.HasValue)
			{
				Element.UndoLimit = nextProps.UndoLimit.Value.Value;
			}
			if (nextProps.AutoWordSelection.HasValue)
			{
				Element.AutoWordSelection = nextProps.AutoWordSelection.Value.Value;
			}
			if (nextProps.SelectionBrush.HasValue)
			{
				Element.SelectionBrush = nextProps.SelectionBrush.Value.Value;
			}
			if (nextProps.SelectionOpacity.HasValue)
			{
				Element.SelectionOpacity = nextProps.SelectionOpacity.Value.Value;
			}
			if (nextProps.CaretBrush.HasValue)
			{
				Element.CaretBrush = nextProps.CaretBrush.Value.Value;
			}
			if (nextProps.IsInactiveSelectionHighlightEnabled.HasValue)
			{
				Element.IsInactiveSelectionHighlightEnabled = nextProps.IsInactiveSelectionHighlightEnabled.Value.Value;
			}
			if (!ReferenceEquals(previous?.TextChanged, null) && ReferenceEquals(nextProps.TextChanged, null))
			{
				Element.TextChanged -= nextProps.TextChanged;
			}
			if (ReferenceEquals(previous?.TextChanged, null) && !ReferenceEquals(nextProps.TextChanged, null))
			{
				Element.TextChanged += nextProps.TextChanged;
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
