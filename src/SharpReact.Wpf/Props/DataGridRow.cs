using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGridRow: Control
	{
		public ReactParam<System.Object>? Item { get; set; }
		public ReactParam<System.Windows.Controls.ItemsPanelTemplate>? ItemsPanel { get; set; }
		public ReactParam<System.Object>? Header { get; set; }
		public ReactParam<System.Windows.Style>? HeaderStyle { get; set; }
		public ReactParam<System.Windows.DataTemplate>? HeaderTemplate { get; set; }
		public ReactParam<System.Windows.Controls.DataTemplateSelector>? HeaderTemplateSelector { get; set; }
		public ReactParam<System.Windows.Controls.ControlTemplate>? ValidationErrorTemplate { get; set; }
		public ReactParam<System.Windows.DataTemplate>? DetailsTemplate { get; set; }
		public ReactParam<System.Windows.Controls.DataTemplateSelector>? DetailsTemplateSelector { get; set; }
		public ReactParam<System.Windows.Visibility>? DetailsVisibility { get; set; }
		public ReactParam<System.Boolean>? IsSelected { get; set; }
		public System.Windows.RoutedEventHandler Selected { get; set; }
		public System.Windows.RoutedEventHandler Unselected { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGridRow<DataGridRow, System.Windows.Controls.DataGridRow>();
		}
	}
}
