using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ListView: AbsListView
	{
		public ReactParam<global::Android.Widget.IListAdapter>? Adapter { get; set; }
		public ReactParam<global::Android.Widget.ChoiceMode>? ChoiceMode { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? Divider { get; set; }
		public ReactParam<global::System.Int32>? DividerHeight { get; set; }
		public ReactParam<global::System.Boolean>? ItemsCanFocus { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? OverscrollFooter { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? OverscrollHeader { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ListView<ListView, global::Android.Widget.ListView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Adapter;
				yield return ChoiceMode;
				yield return Divider;
				yield return DividerHeight;
				yield return ItemsCanFocus;
				yield return OverscrollFooter;
				yield return OverscrollHeader;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
