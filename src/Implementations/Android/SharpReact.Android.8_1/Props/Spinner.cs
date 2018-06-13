using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class Spinner: AbsSpinner
	{
		public ReactParam<global::System.Int32>? DropDownHorizontalOffset { get; set; }
		public ReactParam<global::System.Int32>? DropDownVerticalOffset { get; set; }
		public ReactParam<global::System.Int32>? DropDownWidth { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? PromptFormatted { get; set; }
		public ReactParam<global::System.String>? Prompt { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Spinner<Spinner, global::Android.Widget.Spinner>();
		}
	}
}
