using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class MenuBase: ItemsControl
	{
		public ReactParam<System.Windows.Controls.ItemContainerTemplateSelector>? ItemContainerTemplateSelector { get; set; }
		public ReactParam<System.Boolean>? UsesItemContainerTemplate { get; set; }
	}
}
