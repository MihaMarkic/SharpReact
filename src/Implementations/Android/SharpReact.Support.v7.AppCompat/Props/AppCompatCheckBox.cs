using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class AppCompatCheckBox: CheckBox
	{
		public ReactParam<global::Android.Content.Res.ColorStateList>? SupportButtonTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? SupportButtonTintMode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AppCompatCheckBox<AppCompatCheckBox, global::Android.Support.V7.Widget.AppCompatCheckBox>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return SupportButtonTintList;
				yield return SupportButtonTintMode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
