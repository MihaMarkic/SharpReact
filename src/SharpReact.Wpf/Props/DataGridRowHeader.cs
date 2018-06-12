using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGridRowHeader: ButtonBase
	{
		public ReactParam<global::System.Windows.Media.Brush>? SeparatorBrush { get; set; }
		public ReactParam<global::System.Windows.Visibility>? SeparatorVisibility { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGridRowHeader<DataGridRowHeader, System.Windows.Controls.Primitives.DataGridRowHeader>();
		}
	}
}
