using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class ActionMenuView: LinearLayout
	{
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? OverflowIcon { get; set; }
		public ReactParam<global::System.Int32>? PopupTheme { get; set; }
		public System.EventHandler<global::Android.Widget.ActionMenuView.MenuItemClickEventArgs> MenuItemClick { get; set; }
	}
}
