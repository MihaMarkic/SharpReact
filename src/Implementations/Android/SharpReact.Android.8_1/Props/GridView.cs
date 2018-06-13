using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class GridView: AbsListView
	{
		public ReactParam<global::Android.Widget.IListAdapter>? Adapter { get; set; }
		public ReactParam<global::System.Int32>? NumColumns { get; set; }
		public ReactParam<global::Android.Widget.StretchMode>? StretchMode { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GridView<GridView, global::Android.Widget.GridView>();
		}
	}
}
