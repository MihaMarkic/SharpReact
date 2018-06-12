using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class ListView: AbsListView
	{
		public ReactParam<global::Android.Widget.IListAdapter>? Adapter { get; set; }
		public ReactParam<global::Android.Widget.ChoiceMode>? ChoiceMode { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? Divider { get; set; }
		public ReactParam<global::System.Int32>? DividerHeight { get; set; }
		public ReactParam<global::System.Boolean>? ItemsCanFocus { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? OverscrollFooter { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? OverscrollHeader { get; set; }
	}
}