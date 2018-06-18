using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class TableLayout: LinearLayout
	{
		public ReactParam<global::System.Boolean>? ShrinkAllColumns { get; set; }
		public ReactParam<global::System.Boolean>? StretchAllColumns { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TableLayout<TableLayout, global::Android.Widget.TableLayout>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return ShrinkAllColumns;
				yield return StretchAllColumns;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
