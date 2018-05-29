using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class MenuItem: HeaderedItemsControl
	{
		public ReactParam<System.Windows.Input.ICommand>? Command { get; set; }
		public ReactParam<System.Object>? CommandParameter { get; set; }
		public ReactParam<System.Windows.IInputElement>? CommandTarget { get; set; }
		public ReactParam<System.Boolean>? IsSubmenuOpen { get; set; }
		public ReactParam<System.Boolean>? IsCheckable { get; set; }
		public ReactParam<System.Boolean>? IsChecked { get; set; }
		public ReactParam<System.Boolean>? StaysOpenOnClick { get; set; }
		public ReactParam<System.String>? InputGestureText { get; set; }
		public ReactParam<System.Object>? Icon { get; set; }
		public ReactParam<System.Windows.Controls.ItemContainerTemplateSelector>? ItemContainerTemplateSelector { get; set; }
		public ReactParam<System.Boolean>? UsesItemContainerTemplate { get; set; }
		public System.Windows.RoutedEventHandler Click { get; set; }
		public System.Windows.RoutedEventHandler Checked { get; set; }
		public System.Windows.RoutedEventHandler Unchecked { get; set; }
		public System.Windows.RoutedEventHandler SubmenuOpened { get; set; }
		public System.Windows.RoutedEventHandler SubmenuClosed { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.MenuItem<MenuItem, System.Windows.Controls.MenuItem>();
		}
	}
}
