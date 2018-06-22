using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class GridView: AbsListView
	{
		public ReactParam<global::System.Int32>? NumColumns { get; set; }
		public ReactParam<global::Android.Widget.StretchMode>? StretchMode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GridView<GridView, global::Android.Widget.GridView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return NumColumns;
				yield return StretchMode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
