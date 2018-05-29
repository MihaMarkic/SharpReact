using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class GridViewHeaderRowPresenter: GridViewRowPresenterBase
	{
		public ReactParam<System.Windows.Style>? ColumnHeaderContainerStyle { get; set; }
		public ReactParam<System.Windows.DataTemplate>? ColumnHeaderTemplate { get; set; }
		public ReactParam<System.Windows.Controls.DataTemplateSelector>? ColumnHeaderTemplateSelector { get; set; }
		public ReactParam<System.String>? ColumnHeaderStringFormat { get; set; }
		public ReactParam<System.Boolean>? AllowsColumnReorder { get; set; }
		public ReactParam<System.Windows.Controls.ContextMenu>? ColumnHeaderContextMenu { get; set; }
		public ReactParam<System.Object>? ColumnHeaderToolTip { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GridViewHeaderRowPresenter<GridViewHeaderRowPresenter, System.Windows.Controls.GridViewHeaderRowPresenter>();
		}
	}
}
