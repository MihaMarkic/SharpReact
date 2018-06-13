using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class ExpandableListView: ListView
	{
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		public System.EventHandler<global::Android.Widget.ExpandableListView.ChildClickEventArgs> ChildClick { get; set; }
		public System.EventHandler<global::Android.Widget.ExpandableListView.GroupClickEventArgs> GroupClick { get; set; }
		public System.EventHandler<global::Android.Widget.ExpandableListView.GroupCollapseEventArgs> GroupCollapse { get; set; }
		public System.EventHandler<global::Android.Widget.ExpandableListView.GroupExpandEventArgs> GroupExpand { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ExpandableListView<ExpandableListView, global::Android.Widget.ExpandableListView>();
		}
	}
}
