using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class ActionMenuView: LinearLayoutCompat
	{
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? OverflowIcon { get; set; }
		public ReactParam<global::System.Boolean>? OverflowReserved { get; set; }
		public ReactParam<global::System.Int32>? PopupTheme { get; set; }
		public System.EventHandler<global::Android.Support.V7.Widget.ActionMenuView.MenuItemClickEventArgs> MenuItemClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ActionMenuView<ActionMenuView, global::Android.Support.V7.Widget.ActionMenuView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return OverflowIcon;
				yield return OverflowReserved;
				yield return PopupTheme;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
