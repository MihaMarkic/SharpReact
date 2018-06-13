using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGridCell: ContentControl
	{
		public ReactParam<global::System.Boolean>? IsEditing { get; set; }
		public ReactParam<global::System.Boolean>? IsSelected { get; set; }
		public System.Windows.RoutedEventHandler Selected { get; set; }
		public System.Windows.RoutedEventHandler Unselected { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGridCell<DataGridCell, System.Windows.Controls.DataGridCell>();
		}
	}
}
