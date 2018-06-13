using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class AdapterView: ViewGroup
	{
		public ReactParam<global::Android.Views.View>? EmptyView { get; set; }
		public ReactParam<global::Android.Widget.AdapterView.IOnItemClickListener>? OnItemClickListener { get; set; }
		public ReactParam<global::Android.Widget.AdapterView.IOnItemLongClickListener>? OnItemLongClickListener { get; set; }
		public ReactParam<global::Android.Widget.AdapterView.IOnItemSelectedListener>? OnItemSelectedListener { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		public System.EventHandler<global::Android.Widget.AdapterView.ItemClickEventArgs> ItemClick { get; set; }
		public System.EventHandler<global::Android.Widget.AdapterView.ItemLongClickEventArgs> ItemLongClick { get; set; }
		public System.EventHandler<global::Android.Widget.AdapterView.ItemSelectedEventArgs> ItemSelected { get; set; }
		public System.EventHandler<global::Android.Widget.AdapterView.NothingSelectedEventArgs> NothingSelected { get; set; }
	}
}
