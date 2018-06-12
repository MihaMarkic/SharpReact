using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class HeaderedItemsControl: ItemsControl
	{
		public ReactParam<global::System.Object>? Header { get; set; }
		public ReactParam<global::System.Windows.DataTemplate>? HeaderTemplate { get; set; }
		public ReactParam<global::System.Windows.Controls.DataTemplateSelector>? HeaderTemplateSelector { get; set; }
		public ReactParam<global::System.String>? HeaderStringFormat { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.HeaderedItemsControl<HeaderedItemsControl, System.Windows.Controls.HeaderedItemsControl>();
		}
	}
}
