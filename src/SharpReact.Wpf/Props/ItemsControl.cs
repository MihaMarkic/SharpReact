using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ItemsControl: Control
	{
		public ReactParam<System.Collections.IEnumerable>? ItemsSource { get; set; }
		public ReactParam<System.String>? DisplayMemberPath { get; set; }
		public ReactParam<System.Windows.DataTemplate>? ItemTemplate { get; set; }
		public ReactParam<System.Windows.Controls.DataTemplateSelector>? ItemTemplateSelector { get; set; }
		public ReactParam<System.String>? ItemStringFormat { get; set; }
		public ReactParam<System.Windows.Data.BindingGroup>? ItemBindingGroup { get; set; }
		public ReactParam<System.Windows.Style>? ItemContainerStyle { get; set; }
		public ReactParam<System.Windows.Controls.StyleSelector>? ItemContainerStyleSelector { get; set; }
		public ReactParam<System.Windows.Controls.ItemsPanelTemplate>? ItemsPanel { get; set; }
		public ReactParam<System.Windows.Controls.GroupStyleSelector>? GroupStyleSelector { get; set; }
		public ReactParam<System.Int32>? AlternationCount { get; set; }
		public ReactParam<System.Boolean>? IsTextSearchEnabled { get; set; }
		public ReactParam<System.Boolean>? IsTextSearchCaseSensitive { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ItemsControl<ItemsControl, System.Windows.Controls.ItemsControl>();
		}
	}
}
