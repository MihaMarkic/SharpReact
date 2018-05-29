using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class TreeViewItem: HeaderedItemsControl
	{
		public ReactParam<System.Boolean>? IsExpanded { get; set; }
		public ReactParam<System.Boolean>? IsSelected { get; set; }
		public System.Windows.RoutedEventHandler Expanded { get; set; }
		public System.Windows.RoutedEventHandler Collapsed { get; set; }
		public System.Windows.RoutedEventHandler Selected { get; set; }
		public System.Windows.RoutedEventHandler Unselected { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TreeViewItem<TreeViewItem, System.Windows.Controls.TreeViewItem>();
		}
	}
}
