using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ListBoxItem: ContentControl
	{
		public ReactParam<global::System.Boolean>? IsSelected { get; set; }
		public System.Windows.RoutedEventHandler Selected { get; set; }
		public System.Windows.RoutedEventHandler Unselected { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ListBoxItem<ListBoxItem, System.Windows.Controls.ListBoxItem>();
		}
	}
}
