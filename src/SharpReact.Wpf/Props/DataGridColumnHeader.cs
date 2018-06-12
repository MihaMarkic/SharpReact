using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DataGridColumnHeader: ButtonBase
	{
		public ReactParam<global::System.Windows.Media.Brush>? SeparatorBrush { get; set; }
		public ReactParam<global::System.Windows.Visibility>? SeparatorVisibility { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DataGridColumnHeader<DataGridColumnHeader, System.Windows.Controls.Primitives.DataGridColumnHeader>();
		}
	}
}
