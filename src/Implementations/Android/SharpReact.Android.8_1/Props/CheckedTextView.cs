using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class CheckedTextView: TextView
	{
		public ReactParam<global::Android.Content.Res.ColorStateList>? CheckMarkTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? CheckMarkTintMode { get; set; }
		public ReactParam<global::System.Boolean>? Checked { get; set; }
	}
}
