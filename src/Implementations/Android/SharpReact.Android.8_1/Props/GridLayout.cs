using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class GridLayout: ViewGroup
	{
		public ReactParam<global::Android.Widget.GridAlign>? AlignmentMode { get; set; }
		public ReactParam<global::System.Int32>? ColumnCount { get; set; }
		public ReactParam<global::System.Boolean>? ColumnOrderPreserved { get; set; }
		public ReactParam<global::Android.Widget.GridOrientation>? Orientation { get; set; }
		public ReactParam<global::System.Int32>? RowCount { get; set; }
		public ReactParam<global::System.Boolean>? RowOrderPreserved { get; set; }
		public ReactParam<global::System.Boolean>? UseDefaultMargins { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GridLayout<GridLayout, global::Android.Widget.GridLayout>();
		}
	}
}
