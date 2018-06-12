using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class AutoCompleteTextView: EditText
	{
		public ReactParam<global::Android.Widget.IListAdapter>? Adapter { get; set; }
		public ReactParam<global::System.Int32>? DropDownAnchor { get; set; }
		public ReactParam<global::System.Int32>? DropDownHeight { get; set; }
		public ReactParam<global::System.Int32>? DropDownHorizontalOffset { get; set; }
		public ReactParam<global::System.Int32>? DropDownVerticalOffset { get; set; }
		public ReactParam<global::System.Int32>? DropDownWidth { get; set; }
		public ReactParam<global::System.Int32>? ListSelection { get; set; }
		public ReactParam<global::Android.Widget.AdapterView.IOnItemClickListener>? OnItemClickListener { get; set; }
		public ReactParam<global::Android.Widget.AdapterView.IOnItemSelectedListener>? OnItemSelectedListener { get; set; }
		public ReactParam<global::System.Int32>? Threshold { get; set; }
		public ReactParam<global::Android.Widget.AutoCompleteTextView.IValidator>? Validator { get; set; }
		public System.EventHandler Dismiss { get; set; }
		public System.EventHandler<global::Android.Widget.AdapterView.ItemClickEventArgs> ItemClick { get; set; }
		public System.EventHandler<global::Android.Widget.AdapterView.ItemSelectedEventArgs> ItemSelected { get; set; }
		public System.EventHandler<global::Android.Widget.AdapterView.NothingSelectedEventArgs> NothingSelected { get; set; }
	}
}
