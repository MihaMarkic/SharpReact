using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class MenuBase: ItemsControl
	{
		public ReactParam<global::System.Windows.Controls.ItemContainerTemplateSelector>? ItemContainerTemplateSelector { get; set; }
		public ReactParam<global::System.Boolean>? UsesItemContainerTemplate { get; set; }
	}
}
