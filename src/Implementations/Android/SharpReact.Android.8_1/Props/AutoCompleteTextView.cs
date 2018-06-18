using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class AutoCompleteTextView: EditText
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
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AutoCompleteTextView<AutoCompleteTextView, global::Android.Widget.AutoCompleteTextView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Adapter;
				yield return DropDownAnchor;
				yield return DropDownHeight;
				yield return DropDownHorizontalOffset;
				yield return DropDownVerticalOffset;
				yield return DropDownWidth;
				yield return ListSelection;
				yield return OnItemClickListener;
				yield return OnItemSelectedListener;
				yield return Threshold;
				yield return Validator;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
