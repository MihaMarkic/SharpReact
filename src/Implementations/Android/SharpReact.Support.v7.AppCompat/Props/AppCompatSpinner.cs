using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class AppCompatSpinner: Spinner
	{
		public ReactParam<global::Android.Content.Res.ColorStateList>? SupportBackgroundTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? SupportBackgroundTintMode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AppCompatSpinner<AppCompatSpinner, global::Android.Support.V7.Widget.AppCompatSpinner>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return SupportBackgroundTintList;
				yield return SupportBackgroundTintMode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
