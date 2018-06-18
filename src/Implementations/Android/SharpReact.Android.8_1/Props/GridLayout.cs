using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class GridLayout: ViewGroup
	{
		public ReactParam<global::Android.Widget.GridAlign>? AlignmentMode { get; set; }
		public ReactParam<global::System.Int32>? ColumnCount { get; set; }
		public ReactParam<global::System.Boolean>? ColumnOrderPreserved { get; set; }
		public ReactParam<global::Android.Widget.GridOrientation>? Orientation { get; set; }
		public ReactParam<global::System.Int32>? RowCount { get; set; }
		public ReactParam<global::System.Boolean>? RowOrderPreserved { get; set; }
		public ReactParam<global::System.Boolean>? UseDefaultMargins { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GridLayout<GridLayout, global::Android.Widget.GridLayout>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return AlignmentMode;
				yield return ColumnCount;
				yield return ColumnOrderPreserved;
				yield return Orientation;
				yield return RowCount;
				yield return RowOrderPreserved;
				yield return UseDefaultMargins;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
