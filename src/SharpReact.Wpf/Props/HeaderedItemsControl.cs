using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class HeaderedItemsControl: ItemsControl
	{
		public ReactParam<System.Object>? Header { get; set; }
		public ReactParam<System.Windows.DataTemplate>? HeaderTemplate { get; set; }
		public ReactParam<System.Windows.Controls.DataTemplateSelector>? HeaderTemplateSelector { get; set; }
		public ReactParam<System.String>? HeaderStringFormat { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.HeaderedItemsControl<HeaderedItemsControl, System.Windows.Controls.HeaderedItemsControl>();
		}
	}
}
