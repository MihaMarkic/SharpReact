using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class HeaderedContentControl: ContentControl
	{
		public ReactParam<System.Object>? Header { get; set; }
		public ReactParam<System.Windows.DataTemplate>? HeaderTemplate { get; set; }
		public ReactParam<System.Windows.Controls.DataTemplateSelector>? HeaderTemplateSelector { get; set; }
		public ReactParam<System.String>? HeaderStringFormat { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.HeaderedContentControl<HeaderedContentControl, System.Windows.Controls.HeaderedContentControl>();
		}
	}
}
