using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class Toolbar: ViewGroup
	{
		public ReactParam<global::System.Int32>? ContentInsetEndWithActions { get; set; }
		public ReactParam<global::System.Int32>? ContentInsetStartWithNavigation { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? Logo { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? LogoDescriptionFormatted { get; set; }
		public ReactParam<global::System.String>? LogoDescription { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? NavigationContentDescriptionFormatted { get; set; }
		public ReactParam<global::System.String>? NavigationContentDescription { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? NavigationIcon { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? OverflowIcon { get; set; }
		public ReactParam<global::System.Int32>? PopupTheme { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? SubtitleFormatted { get; set; }
		public ReactParam<global::System.String>? Subtitle { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? TitleFormatted { get; set; }
		public ReactParam<global::System.String>? Title { get; set; }
		public ReactParam<global::System.Int32>? TitleMarginBottom { get; set; }
		public ReactParam<global::System.Int32>? TitleMarginEnd { get; set; }
		public ReactParam<global::System.Int32>? TitleMarginStart { get; set; }
		public ReactParam<global::System.Int32>? TitleMarginTop { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		public System.EventHandler NavigationOnClick { get; set; }
		public System.EventHandler<global::Android.Widget.Toolbar.MenuItemClickEventArgs> MenuItemClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Toolbar<Toolbar, global::Android.Widget.Toolbar>();
		}
	}
}
