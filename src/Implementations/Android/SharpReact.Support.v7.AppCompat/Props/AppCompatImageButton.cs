using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class AppCompatImageButton: ImageButton
	{
		public ReactParam<global::Android.Content.Res.ColorStateList>? SupportBackgroundTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? SupportBackgroundTintMode { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? SupportImageTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? SupportImageTintMode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AppCompatImageButton<AppCompatImageButton, global::Android.Support.V7.Widget.AppCompatImageButton>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return SupportBackgroundTintList;
				yield return SupportBackgroundTintMode;
				yield return SupportImageTintList;
				yield return SupportImageTintMode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
