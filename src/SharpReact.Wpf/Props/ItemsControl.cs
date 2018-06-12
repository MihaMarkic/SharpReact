using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ItemsControl: Control
	{
		public ReactParam<global::System.Collections.IEnumerable>? ItemsSource { get; set; }
		public ReactParam<global::System.String>? DisplayMemberPath { get; set; }
		public ReactParam<global::System.Windows.DataTemplate>? ItemTemplate { get; set; }
		public ReactParam<global::System.Windows.Controls.DataTemplateSelector>? ItemTemplateSelector { get; set; }
		public ReactParam<global::System.String>? ItemStringFormat { get; set; }
		public ReactParam<global::System.Windows.Data.BindingGroup>? ItemBindingGroup { get; set; }
		public ReactParam<global::System.Windows.Style>? ItemContainerStyle { get; set; }
		public ReactParam<global::System.Windows.Controls.StyleSelector>? ItemContainerStyleSelector { get; set; }
		public ReactParam<global::System.Windows.Controls.ItemsPanelTemplate>? ItemsPanel { get; set; }
		public ReactParam<global::System.Windows.Controls.GroupStyleSelector>? GroupStyleSelector { get; set; }
		public ReactParam<global::System.Int32>? AlternationCount { get; set; }
		public ReactParam<global::System.Boolean>? IsTextSearchEnabled { get; set; }
		public ReactParam<global::System.Boolean>? IsTextSearchCaseSensitive { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ItemsControl<ItemsControl, System.Windows.Controls.ItemsControl>();
		}
	}
}
