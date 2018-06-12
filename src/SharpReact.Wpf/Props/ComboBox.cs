using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ComboBox: Selector
	{
		public ReactParam<global::System.Double>? MaxDropDownHeight { get; set; }
		public ReactParam<global::System.Boolean>? IsDropDownOpen { get; set; }
		public ReactParam<global::System.Boolean>? ShouldPreserveUserEnteredPrefix { get; set; }
		public ReactParam<global::System.Boolean>? IsEditable { get; set; }
		public ReactParam<global::System.String>? Text { get; set; }
		public ReactParam<global::System.Boolean>? IsReadOnly { get; set; }
		public ReactParam<global::System.Boolean>? StaysOpenOnEdit { get; set; }
		public System.EventHandler DropDownOpened { get; set; }
		public System.EventHandler DropDownClosed { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ComboBox<ComboBox, System.Windows.Controls.ComboBox>();
		}
	}
}
