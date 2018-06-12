using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DockPanel: Panel
	{
		public ReactParam<global::System.Boolean>? LastChildFill { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DockPanel<DockPanel, System.Windows.Controls.DockPanel>();
		}
	}
}
