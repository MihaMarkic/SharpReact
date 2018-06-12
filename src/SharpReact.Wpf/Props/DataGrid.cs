using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGrid: MultiSelector
	{
		public ReactParam<global::System.Boolean>? CanUserResizeColumns { get; set; }
		public ReactParam<global::System.Windows.Controls.DataGridLength>? ColumnWidth { get; set; }
		public ReactParam<global::System.Double>? MinColumnWidth { get; set; }
		public ReactParam<global::System.Double>? MaxColumnWidth { get; set; }
		public ReactParam<global::System.Windows.Controls.DataGridGridLinesVisibility>? GridLinesVisibility { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? HorizontalGridLinesBrush { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? VerticalGridLinesBrush { get; set; }
		public ReactParam<global::System.Windows.Style>? RowStyle { get; set; }
		public ReactParam<global::System.Windows.Controls.ControlTemplate>? RowValidationErrorTemplate { get; set; }
		public ReactParam<global::System.Windows.Controls.StyleSelector>? RowStyleSelector { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? RowBackground { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? AlternatingRowBackground { get; set; }
		public ReactParam<global::System.Double>? RowHeight { get; set; }
		public ReactParam<global::System.Double>? MinRowHeight { get; set; }
		public ReactParam<global::System.Double>? RowHeaderWidth { get; set; }
		public ReactParam<global::System.Double>? ColumnHeaderHeight { get; set; }
		public ReactParam<global::System.Windows.Controls.DataGridHeadersVisibility>? HeadersVisibility { get; set; }
		public ReactParam<global::System.Windows.Style>? CellStyle { get; set; }
		public ReactParam<global::System.Windows.Style>? ColumnHeaderStyle { get; set; }
		public ReactParam<global::System.Windows.Style>? RowHeaderStyle { get; set; }
		public ReactParam<global::System.Windows.DataTemplate>? RowHeaderTemplate { get; set; }
		public ReactParam<global::System.Windows.Controls.DataTemplateSelector>? RowHeaderTemplateSelector { get; set; }
		public ReactParam<global::System.Windows.Controls.ScrollBarVisibility>? HorizontalScrollBarVisibility { get; set; }
		public ReactParam<global::System.Windows.Controls.ScrollBarVisibility>? VerticalScrollBarVisibility { get; set; }
		public ReactParam<global::System.Boolean>? IsReadOnly { get; set; }
		public ReactParam<global::System.Object>? CurrentItem { get; set; }
		public ReactParam<global::System.Windows.Controls.DataGridColumn>? CurrentColumn { get; set; }
		public ReactParam<global::System.Windows.Controls.DataGridCellInfo>? CurrentCell { get; set; }
		public ReactParam<global::System.Boolean>? CanUserAddRows { get; set; }
		public ReactParam<global::System.Boolean>? CanUserDeleteRows { get; set; }
		public ReactParam<global::System.Windows.Controls.DataGridRowDetailsVisibilityMode>? RowDetailsVisibilityMode { get; set; }
		public ReactParam<global::System.Boolean>? AreRowDetailsFrozen { get; set; }
		public ReactParam<global::System.Windows.DataTemplate>? RowDetailsTemplate { get; set; }
		public ReactParam<global::System.Windows.Controls.DataTemplateSelector>? RowDetailsTemplateSelector { get; set; }
		public ReactParam<global::System.Boolean>? CanUserResizeRows { get; set; }
		public ReactParam<global::System.Windows.Controls.DataGridSelectionMode>? SelectionMode { get; set; }
		public ReactParam<global::System.Windows.Controls.DataGridSelectionUnit>? SelectionUnit { get; set; }
		public ReactParam<global::System.Boolean>? CanUserSortColumns { get; set; }
		public ReactParam<global::System.Boolean>? AutoGenerateColumns { get; set; }
		public ReactParam<global::System.Int32>? FrozenColumnCount { get; set; }
		public ReactParam<global::System.Boolean>? EnableRowVirtualization { get; set; }
		public ReactParam<global::System.Boolean>? EnableColumnVirtualization { get; set; }
		public ReactParam<global::System.Boolean>? CanUserReorderColumns { get; set; }
		public ReactParam<global::System.Windows.Style>? DragIndicatorStyle { get; set; }
		public ReactParam<global::System.Windows.Style>? DropLocationIndicatorStyle { get; set; }
		public ReactParam<global::System.Windows.Controls.DataGridClipboardCopyMode>? ClipboardCopyMode { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridColumnEventArgs> ColumnDisplayIndexChanged { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridRowEventArgs> LoadingRow { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridRowEventArgs> UnloadingRow { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridRowEditEndingEventArgs> RowEditEnding { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridCellEditEndingEventArgs> CellEditEnding { get; set; }
		public System.EventHandler<global::System.EventArgs> CurrentCellChanged { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridBeginningEditEventArgs> BeginningEdit { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridPreparingCellForEditEventArgs> PreparingCellForEdit { get; set; }
		public System.EventHandler<global::System.Windows.Controls.AddingNewItemEventArgs> AddingNewItem { get; set; }
		public System.Windows.Controls.InitializingNewItemEventHandler InitializingNewItem { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridRowDetailsEventArgs> LoadingRowDetails { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridRowDetailsEventArgs> UnloadingRowDetails { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridRowDetailsEventArgs> RowDetailsVisibilityChanged { get; set; }
		public System.Windows.Controls.SelectedCellsChangedEventHandler SelectedCellsChanged { get; set; }
		public System.Windows.Controls.DataGridSortingEventHandler Sorting { get; set; }
		public System.EventHandler AutoGeneratedColumns { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> AutoGeneratingColumn { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridColumnReorderingEventArgs> ColumnReordering { get; set; }
		public System.EventHandler<global::System.Windows.Controls.Primitives.DragStartedEventArgs> ColumnHeaderDragStarted { get; set; }
		public System.EventHandler<global::System.Windows.Controls.Primitives.DragDeltaEventArgs> ColumnHeaderDragDelta { get; set; }
		public System.EventHandler<global::System.Windows.Controls.Primitives.DragCompletedEventArgs> ColumnHeaderDragCompleted { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridColumnEventArgs> ColumnReordered { get; set; }
		public System.EventHandler<global::System.Windows.Controls.DataGridRowClipboardEventArgs> CopyingRowClipboardContent { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGrid<DataGrid, System.Windows.Controls.DataGrid>();
		}
	}
}
