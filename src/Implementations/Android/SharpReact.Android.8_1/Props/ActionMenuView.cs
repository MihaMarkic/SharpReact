using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class ActionMenuView: LinearLayout
	{
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? OverflowIcon { get; set; }
		public ReactParam<global::System.Int32>? PopupTheme { get; set; }
		public System.EventHandler<global::Android.Widget.ActionMenuView.MenuItemClickEventArgs> MenuItemClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ActionMenuView<ActionMenuView, global::Android.Widget.ActionMenuView>();
		}
	}
}
