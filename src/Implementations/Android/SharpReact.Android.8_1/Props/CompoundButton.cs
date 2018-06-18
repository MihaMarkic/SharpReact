using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract partial class CompoundButton: Button
	{
		public ReactParam<global::Android.Content.Res.ColorStateList>? ButtonTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? ButtonTintMode { get; set; }
		public ReactParam<global::System.Boolean>? Checked { get; set; }
		public System.EventHandler<global::Android.Widget.CompoundButton.CheckedChangeEventArgs> CheckedChange { get; set; }
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return ButtonTintList;
				yield return ButtonTintMode;
				yield return Checked;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
