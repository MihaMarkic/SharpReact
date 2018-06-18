using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class CheckedTextView: TextView
	{
		public ReactParam<global::Android.Content.Res.ColorStateList>? CheckMarkTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? CheckMarkTintMode { get; set; }
		public ReactParam<global::System.Boolean>? Checked { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.CheckedTextView<CheckedTextView, global::Android.Widget.CheckedTextView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return CheckMarkTintList;
				yield return CheckMarkTintMode;
				yield return Checked;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
