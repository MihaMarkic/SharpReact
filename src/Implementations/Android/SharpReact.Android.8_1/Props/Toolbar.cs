using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class Toolbar: ViewGroup
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
		public System.EventHandler NavigationOnClick { get; set; }
		public System.EventHandler<global::Android.Widget.Toolbar.MenuItemClickEventArgs> MenuItemClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Toolbar<Toolbar, global::Android.Widget.Toolbar>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return ContentInsetEndWithActions;
				yield return ContentInsetStartWithNavigation;
				yield return Logo;
				yield return LogoDescriptionFormatted;
				yield return LogoDescription;
				yield return NavigationContentDescriptionFormatted;
				yield return NavigationContentDescription;
				yield return NavigationIcon;
				yield return OverflowIcon;
				yield return PopupTheme;
				yield return SubtitleFormatted;
				yield return Subtitle;
				yield return TitleFormatted;
				yield return Title;
				yield return TitleMarginBottom;
				yield return TitleMarginEnd;
				yield return TitleMarginStart;
				yield return TitleMarginTop;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
