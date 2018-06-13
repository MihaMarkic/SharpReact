using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class TableLayout: LinearLayout
	{
		public ReactParam<global::System.Boolean>? ShrinkAllColumns { get; set; }
		public ReactParam<global::System.Boolean>? StretchAllColumns { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TableLayout<TableLayout, global::Android.Widget.TableLayout>();
		}
	}
}
