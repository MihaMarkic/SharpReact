using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DataGrid<TProps, TElement>: MultiSelector<TProps, TElement>
		where TProps : Props.DataGrid
		where TElement : global::System.Windows.Controls.DataGrid, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.CanUserResizeColumns.HasValue)
			{
				Element.CanUserResizeColumns = nextProps.CanUserResizeColumns.Value.Value;
			}
			if (nextProps.ColumnWidth.HasValue)
			{
				Element.ColumnWidth = nextProps.ColumnWidth.Value.Value;
			}
			if (nextProps.MinColumnWidth.HasValue)
			{
				Element.MinColumnWidth = nextProps.MinColumnWidth.Value.Value;
			}
			if (nextProps.MaxColumnWidth.HasValue)
			{
				Element.MaxColumnWidth = nextProps.MaxColumnWidth.Value.Value;
			}
			if (nextProps.GridLinesVisibility.HasValue)
			{
				Element.GridLinesVisibility = nextProps.GridLinesVisibility.Value.Value;
			}
			if (nextProps.HorizontalGridLinesBrush.HasValue)
			{
				Element.HorizontalGridLinesBrush = nextProps.HorizontalGridLinesBrush.Value.Value;
			}
			if (nextProps.VerticalGridLinesBrush.HasValue)
			{
				Element.VerticalGridLinesBrush = nextProps.VerticalGridLinesBrush.Value.Value;
			}
			if (nextProps.RowStyle.HasValue)
			{
				Element.RowStyle = nextProps.RowStyle.Value.Value;
			}
			if (nextProps.RowValidationErrorTemplate.HasValue)
			{
				Element.RowValidationErrorTemplate = nextProps.RowValidationErrorTemplate.Value.Value;
			}
			if (nextProps.RowStyleSelector.HasValue)
			{
				Element.RowStyleSelector = nextProps.RowStyleSelector.Value.Value;
			}
			if (nextProps.RowBackground.HasValue)
			{
				Element.RowBackground = nextProps.RowBackground.Value.Value;
			}
			if (nextProps.AlternatingRowBackground.HasValue)
			{
				Element.AlternatingRowBackground = nextProps.AlternatingRowBackground.Value.Value;
			}
			if (nextProps.RowHeight.HasValue)
			{
				Element.RowHeight = nextProps.RowHeight.Value.Value;
			}
			if (nextProps.MinRowHeight.HasValue)
			{
				Element.MinRowHeight = nextProps.MinRowHeight.Value.Value;
			}
			if (nextProps.RowHeaderWidth.HasValue)
			{
				Element.RowHeaderWidth = nextProps.RowHeaderWidth.Value.Value;
			}
			if (nextProps.ColumnHeaderHeight.HasValue)
			{
				Element.ColumnHeaderHeight = nextProps.ColumnHeaderHeight.Value.Value;
			}
			if (nextProps.HeadersVisibility.HasValue)
			{
				Element.HeadersVisibility = nextProps.HeadersVisibility.Value.Value;
			}
			if (nextProps.CellStyle.HasValue)
			{
				Element.CellStyle = nextProps.CellStyle.Value.Value;
			}
			if (nextProps.ColumnHeaderStyle.HasValue)
			{
				Element.ColumnHeaderStyle = nextProps.ColumnHeaderStyle.Value.Value;
			}
			if (nextProps.RowHeaderStyle.HasValue)
			{
				Element.RowHeaderStyle = nextProps.RowHeaderStyle.Value.Value;
			}
			if (nextProps.RowHeaderTemplate.HasValue)
			{
				Element.RowHeaderTemplate = nextProps.RowHeaderTemplate.Value.Value;
			}
			if (nextProps.RowHeaderTemplateSelector.HasValue)
			{
				Element.RowHeaderTemplateSelector = nextProps.RowHeaderTemplateSelector.Value.Value;
			}
			if (nextProps.HorizontalScrollBarVisibility.HasValue)
			{
				Element.HorizontalScrollBarVisibility = nextProps.HorizontalScrollBarVisibility.Value.Value;
			}
			if (nextProps.VerticalScrollBarVisibility.HasValue)
			{
				Element.VerticalScrollBarVisibility = nextProps.VerticalScrollBarVisibility.Value.Value;
			}
			if (nextProps.IsReadOnly.HasValue)
			{
				Element.IsReadOnly = nextProps.IsReadOnly.Value.Value;
			}
			if (nextProps.CurrentItem.HasValue)
			{
				Element.CurrentItem = nextProps.CurrentItem.Value.Value;
			}
			if (nextProps.CurrentColumn.HasValue)
			{
				Element.CurrentColumn = nextProps.CurrentColumn.Value.Value;
			}
			if (nextProps.CurrentCell.HasValue)
			{
				Element.CurrentCell = nextProps.CurrentCell.Value.Value;
			}
			if (nextProps.CanUserAddRows.HasValue)
			{
				Element.CanUserAddRows = nextProps.CanUserAddRows.Value.Value;
			}
			if (nextProps.CanUserDeleteRows.HasValue)
			{
				Element.CanUserDeleteRows = nextProps.CanUserDeleteRows.Value.Value;
			}
			if (nextProps.RowDetailsVisibilityMode.HasValue)
			{
				Element.RowDetailsVisibilityMode = nextProps.RowDetailsVisibilityMode.Value.Value;
			}
			if (nextProps.AreRowDetailsFrozen.HasValue)
			{
				Element.AreRowDetailsFrozen = nextProps.AreRowDetailsFrozen.Value.Value;
			}
			if (nextProps.RowDetailsTemplate.HasValue)
			{
				Element.RowDetailsTemplate = nextProps.RowDetailsTemplate.Value.Value;
			}
			if (nextProps.RowDetailsTemplateSelector.HasValue)
			{
				Element.RowDetailsTemplateSelector = nextProps.RowDetailsTemplateSelector.Value.Value;
			}
			if (nextProps.CanUserResizeRows.HasValue)
			{
				Element.CanUserResizeRows = nextProps.CanUserResizeRows.Value.Value;
			}
			if (nextProps.SelectionMode.HasValue)
			{
				Element.SelectionMode = nextProps.SelectionMode.Value.Value;
			}
			if (nextProps.SelectionUnit.HasValue)
			{
				Element.SelectionUnit = nextProps.SelectionUnit.Value.Value;
			}
			if (nextProps.CanUserSortColumns.HasValue)
			{
				Element.CanUserSortColumns = nextProps.CanUserSortColumns.Value.Value;
			}
			if (nextProps.AutoGenerateColumns.HasValue)
			{
				Element.AutoGenerateColumns = nextProps.AutoGenerateColumns.Value.Value;
			}
			if (nextProps.FrozenColumnCount.HasValue)
			{
				Element.FrozenColumnCount = nextProps.FrozenColumnCount.Value.Value;
			}
			if (nextProps.EnableRowVirtualization.HasValue)
			{
				Element.EnableRowVirtualization = nextProps.EnableRowVirtualization.Value.Value;
			}
			if (nextProps.EnableColumnVirtualization.HasValue)
			{
				Element.EnableColumnVirtualization = nextProps.EnableColumnVirtualization.Value.Value;
			}
			if (nextProps.CanUserReorderColumns.HasValue)
			{
				Element.CanUserReorderColumns = nextProps.CanUserReorderColumns.Value.Value;
			}
			if (nextProps.DragIndicatorStyle.HasValue)
			{
				Element.DragIndicatorStyle = nextProps.DragIndicatorStyle.Value.Value;
			}
			if (nextProps.DropLocationIndicatorStyle.HasValue)
			{
				Element.DropLocationIndicatorStyle = nextProps.DropLocationIndicatorStyle.Value.Value;
			}
			if (nextProps.ClipboardCopyMode.HasValue)
			{
				Element.ClipboardCopyMode = nextProps.ClipboardCopyMode.Value.Value;
			}
			if (!ReferenceEquals(previous?.ColumnDisplayIndexChanged, null) && ReferenceEquals(nextProps.ColumnDisplayIndexChanged, null))
			{
				Element.ColumnDisplayIndexChanged -= nextProps.ColumnDisplayIndexChanged;
			}
			if (ReferenceEquals(previous?.ColumnDisplayIndexChanged, null) && !ReferenceEquals(nextProps.ColumnDisplayIndexChanged, null))
			{
				Element.ColumnDisplayIndexChanged += nextProps.ColumnDisplayIndexChanged;
			}
			if (!ReferenceEquals(previous?.LoadingRow, null) && ReferenceEquals(nextProps.LoadingRow, null))
			{
				Element.LoadingRow -= nextProps.LoadingRow;
			}
			if (ReferenceEquals(previous?.LoadingRow, null) && !ReferenceEquals(nextProps.LoadingRow, null))
			{
				Element.LoadingRow += nextProps.LoadingRow;
			}
			if (!ReferenceEquals(previous?.UnloadingRow, null) && ReferenceEquals(nextProps.UnloadingRow, null))
			{
				Element.UnloadingRow -= nextProps.UnloadingRow;
			}
			if (ReferenceEquals(previous?.UnloadingRow, null) && !ReferenceEquals(nextProps.UnloadingRow, null))
			{
				Element.UnloadingRow += nextProps.UnloadingRow;
			}
			if (!ReferenceEquals(previous?.RowEditEnding, null) && ReferenceEquals(nextProps.RowEditEnding, null))
			{
				Element.RowEditEnding -= nextProps.RowEditEnding;
			}
			if (ReferenceEquals(previous?.RowEditEnding, null) && !ReferenceEquals(nextProps.RowEditEnding, null))
			{
				Element.RowEditEnding += nextProps.RowEditEnding;
			}
			if (!ReferenceEquals(previous?.CellEditEnding, null) && ReferenceEquals(nextProps.CellEditEnding, null))
			{
				Element.CellEditEnding -= nextProps.CellEditEnding;
			}
			if (ReferenceEquals(previous?.CellEditEnding, null) && !ReferenceEquals(nextProps.CellEditEnding, null))
			{
				Element.CellEditEnding += nextProps.CellEditEnding;
			}
			if (!ReferenceEquals(previous?.CurrentCellChanged, null) && ReferenceEquals(nextProps.CurrentCellChanged, null))
			{
				Element.CurrentCellChanged -= nextProps.CurrentCellChanged;
			}
			if (ReferenceEquals(previous?.CurrentCellChanged, null) && !ReferenceEquals(nextProps.CurrentCellChanged, null))
			{
				Element.CurrentCellChanged += nextProps.CurrentCellChanged;
			}
			if (!ReferenceEquals(previous?.BeginningEdit, null) && ReferenceEquals(nextProps.BeginningEdit, null))
			{
				Element.BeginningEdit -= nextProps.BeginningEdit;
			}
			if (ReferenceEquals(previous?.BeginningEdit, null) && !ReferenceEquals(nextProps.BeginningEdit, null))
			{
				Element.BeginningEdit += nextProps.BeginningEdit;
			}
			if (!ReferenceEquals(previous?.PreparingCellForEdit, null) && ReferenceEquals(nextProps.PreparingCellForEdit, null))
			{
				Element.PreparingCellForEdit -= nextProps.PreparingCellForEdit;
			}
			if (ReferenceEquals(previous?.PreparingCellForEdit, null) && !ReferenceEquals(nextProps.PreparingCellForEdit, null))
			{
				Element.PreparingCellForEdit += nextProps.PreparingCellForEdit;
			}
			if (!ReferenceEquals(previous?.AddingNewItem, null) && ReferenceEquals(nextProps.AddingNewItem, null))
			{
				Element.AddingNewItem -= nextProps.AddingNewItem;
			}
			if (ReferenceEquals(previous?.AddingNewItem, null) && !ReferenceEquals(nextProps.AddingNewItem, null))
			{
				Element.AddingNewItem += nextProps.AddingNewItem;
			}
			if (!ReferenceEquals(previous?.InitializingNewItem, null) && ReferenceEquals(nextProps.InitializingNewItem, null))
			{
				Element.InitializingNewItem -= nextProps.InitializingNewItem;
			}
			if (ReferenceEquals(previous?.InitializingNewItem, null) && !ReferenceEquals(nextProps.InitializingNewItem, null))
			{
				Element.InitializingNewItem += nextProps.InitializingNewItem;
			}
			if (!ReferenceEquals(previous?.LoadingRowDetails, null) && ReferenceEquals(nextProps.LoadingRowDetails, null))
			{
				Element.LoadingRowDetails -= nextProps.LoadingRowDetails;
			}
			if (ReferenceEquals(previous?.LoadingRowDetails, null) && !ReferenceEquals(nextProps.LoadingRowDetails, null))
			{
				Element.LoadingRowDetails += nextProps.LoadingRowDetails;
			}
			if (!ReferenceEquals(previous?.UnloadingRowDetails, null) && ReferenceEquals(nextProps.UnloadingRowDetails, null))
			{
				Element.UnloadingRowDetails -= nextProps.UnloadingRowDetails;
			}
			if (ReferenceEquals(previous?.UnloadingRowDetails, null) && !ReferenceEquals(nextProps.UnloadingRowDetails, null))
			{
				Element.UnloadingRowDetails += nextProps.UnloadingRowDetails;
			}
			if (!ReferenceEquals(previous?.RowDetailsVisibilityChanged, null) && ReferenceEquals(nextProps.RowDetailsVisibilityChanged, null))
			{
				Element.RowDetailsVisibilityChanged -= nextProps.RowDetailsVisibilityChanged;
			}
			if (ReferenceEquals(previous?.RowDetailsVisibilityChanged, null) && !ReferenceEquals(nextProps.RowDetailsVisibilityChanged, null))
			{
				Element.RowDetailsVisibilityChanged += nextProps.RowDetailsVisibilityChanged;
			}
			if (!ReferenceEquals(previous?.SelectedCellsChanged, null) && ReferenceEquals(nextProps.SelectedCellsChanged, null))
			{
				Element.SelectedCellsChanged -= nextProps.SelectedCellsChanged;
			}
			if (ReferenceEquals(previous?.SelectedCellsChanged, null) && !ReferenceEquals(nextProps.SelectedCellsChanged, null))
			{
				Element.SelectedCellsChanged += nextProps.SelectedCellsChanged;
			}
			if (!ReferenceEquals(previous?.Sorting, null) && ReferenceEquals(nextProps.Sorting, null))
			{
				Element.Sorting -= nextProps.Sorting;
			}
			if (ReferenceEquals(previous?.Sorting, null) && !ReferenceEquals(nextProps.Sorting, null))
			{
				Element.Sorting += nextProps.Sorting;
			}
			if (!ReferenceEquals(previous?.AutoGeneratedColumns, null) && ReferenceEquals(nextProps.AutoGeneratedColumns, null))
			{
				Element.AutoGeneratedColumns -= nextProps.AutoGeneratedColumns;
			}
			if (ReferenceEquals(previous?.AutoGeneratedColumns, null) && !ReferenceEquals(nextProps.AutoGeneratedColumns, null))
			{
				Element.AutoGeneratedColumns += nextProps.AutoGeneratedColumns;
			}
			if (!ReferenceEquals(previous?.AutoGeneratingColumn, null) && ReferenceEquals(nextProps.AutoGeneratingColumn, null))
			{
				Element.AutoGeneratingColumn -= nextProps.AutoGeneratingColumn;
			}
			if (ReferenceEquals(previous?.AutoGeneratingColumn, null) && !ReferenceEquals(nextProps.AutoGeneratingColumn, null))
			{
				Element.AutoGeneratingColumn += nextProps.AutoGeneratingColumn;
			}
			if (!ReferenceEquals(previous?.ColumnReordering, null) && ReferenceEquals(nextProps.ColumnReordering, null))
			{
				Element.ColumnReordering -= nextProps.ColumnReordering;
			}
			if (ReferenceEquals(previous?.ColumnReordering, null) && !ReferenceEquals(nextProps.ColumnReordering, null))
			{
				Element.ColumnReordering += nextProps.ColumnReordering;
			}
			if (!ReferenceEquals(previous?.ColumnHeaderDragStarted, null) && ReferenceEquals(nextProps.ColumnHeaderDragStarted, null))
			{
				Element.ColumnHeaderDragStarted -= nextProps.ColumnHeaderDragStarted;
			}
			if (ReferenceEquals(previous?.ColumnHeaderDragStarted, null) && !ReferenceEquals(nextProps.ColumnHeaderDragStarted, null))
			{
				Element.ColumnHeaderDragStarted += nextProps.ColumnHeaderDragStarted;
			}
			if (!ReferenceEquals(previous?.ColumnHeaderDragDelta, null) && ReferenceEquals(nextProps.ColumnHeaderDragDelta, null))
			{
				Element.ColumnHeaderDragDelta -= nextProps.ColumnHeaderDragDelta;
			}
			if (ReferenceEquals(previous?.ColumnHeaderDragDelta, null) && !ReferenceEquals(nextProps.ColumnHeaderDragDelta, null))
			{
				Element.ColumnHeaderDragDelta += nextProps.ColumnHeaderDragDelta;
			}
			if (!ReferenceEquals(previous?.ColumnHeaderDragCompleted, null) && ReferenceEquals(nextProps.ColumnHeaderDragCompleted, null))
			{
				Element.ColumnHeaderDragCompleted -= nextProps.ColumnHeaderDragCompleted;
			}
			if (ReferenceEquals(previous?.ColumnHeaderDragCompleted, null) && !ReferenceEquals(nextProps.ColumnHeaderDragCompleted, null))
			{
				Element.ColumnHeaderDragCompleted += nextProps.ColumnHeaderDragCompleted;
			}
			if (!ReferenceEquals(previous?.ColumnReordered, null) && ReferenceEquals(nextProps.ColumnReordered, null))
			{
				Element.ColumnReordered -= nextProps.ColumnReordered;
			}
			if (ReferenceEquals(previous?.ColumnReordered, null) && !ReferenceEquals(nextProps.ColumnReordered, null))
			{
				Element.ColumnReordered += nextProps.ColumnReordered;
			}
			if (!ReferenceEquals(previous?.CopyingRowClipboardContent, null) && ReferenceEquals(nextProps.CopyingRowClipboardContent, null))
			{
				Element.CopyingRowClipboardContent -= nextProps.CopyingRowClipboardContent;
			}
			if (ReferenceEquals(previous?.CopyingRowClipboardContent, null) && !ReferenceEquals(nextProps.CopyingRowClipboardContent, null))
			{
				Element.CopyingRowClipboardContent += nextProps.CopyingRowClipboardContent;
			}
		}
	}
}
