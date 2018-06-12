using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class TabItem: HeaderedContentControl
	{
		public ReactParam<global::System.Boolean>? IsSelected { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TabItem<TabItem, System.Windows.Controls.TabItem>();
		}
	}
}
