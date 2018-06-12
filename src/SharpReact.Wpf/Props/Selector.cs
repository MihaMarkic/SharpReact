using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class Selector: ItemsControl
	{
		public ReactParam<global::System.Nullable<System.Boolean>>? IsSynchronizedWithCurrentItem { get; set; }
		public ReactParam<global::System.Int32>? SelectedIndex { get; set; }
		public ReactParam<global::System.Object>? SelectedItem { get; set; }
		public ReactParam<global::System.Object>? SelectedValue { get; set; }
		public ReactParam<global::System.String>? SelectedValuePath { get; set; }
		public System.Windows.Controls.SelectionChangedEventHandler SelectionChanged { get; set; }
	}
}
