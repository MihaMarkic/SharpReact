using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class TreeView: ItemsControl
	{
		public ReactParam<global::System.String>? SelectedValuePath { get; set; }
		public System.Windows.RoutedPropertyChangedEventHandler<global::System.Object> SelectedItemChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TreeView<TreeView, System.Windows.Controls.TreeView>();
		}
	}
}
