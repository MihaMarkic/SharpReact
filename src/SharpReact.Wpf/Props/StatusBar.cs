using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class StatusBar: ItemsControl
	{
		public ReactParam<System.Windows.Controls.ItemContainerTemplateSelector>? ItemContainerTemplateSelector { get; set; }
		public ReactParam<System.Boolean>? UsesItemContainerTemplate { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.StatusBar<StatusBar, System.Windows.Controls.Primitives.StatusBar>();
		}
	}
}
