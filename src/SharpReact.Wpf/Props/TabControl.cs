using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class TabControl: Selector
	{
		public ReactParam<System.Windows.Controls.Dock>? TabStripPlacement { get; set; }
		public ReactParam<System.Windows.DataTemplate>? ContentTemplate { get; set; }
		public ReactParam<System.Windows.Controls.DataTemplateSelector>? ContentTemplateSelector { get; set; }
		public ReactParam<System.String>? ContentStringFormat { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TabControl<TabControl, System.Windows.Controls.TabControl>();
		}
	}
}
