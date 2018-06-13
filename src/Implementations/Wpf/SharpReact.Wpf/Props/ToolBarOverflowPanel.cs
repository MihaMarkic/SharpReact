using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ToolBarOverflowPanel: Panel
	{
		public ReactParam<global::System.Double>? WrapWidth { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ToolBarOverflowPanel<ToolBarOverflowPanel, System.Windows.Controls.Primitives.ToolBarOverflowPanel>();
		}
	}
}
