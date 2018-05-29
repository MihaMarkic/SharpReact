using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class UniformGrid: Panel
	{
		public ReactParam<System.Int32>? FirstColumn { get; set; }
		public ReactParam<System.Int32>? Columns { get; set; }
		public ReactParam<System.Int32>? Rows { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.UniformGrid<UniformGrid, System.Windows.Controls.Primitives.UniformGrid>();
		}
	}
}
