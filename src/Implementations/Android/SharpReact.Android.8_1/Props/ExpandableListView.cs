using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class ExpandableListView: ListView
	{
		public System.EventHandler<global::Android.Widget.ExpandableListView.ChildClickEventArgs> ChildClick { get; set; }
		public System.EventHandler<global::Android.Widget.ExpandableListView.GroupClickEventArgs> GroupClick { get; set; }
		public System.EventHandler<global::Android.Widget.ExpandableListView.GroupCollapseEventArgs> GroupCollapse { get; set; }
		public System.EventHandler<global::Android.Widget.ExpandableListView.GroupExpandEventArgs> GroupExpand { get; set; }
	}
}
