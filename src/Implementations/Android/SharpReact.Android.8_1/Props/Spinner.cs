using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class Spinner: AbsSpinner
	{
		public ReactParam<global::System.Int32>? DropDownHorizontalOffset { get; set; }
		public ReactParam<global::System.Int32>? DropDownVerticalOffset { get; set; }
		public ReactParam<global::System.Int32>? DropDownWidth { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? PromptFormatted { get; set; }
		public ReactParam<global::System.String>? Prompt { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Spinner<Spinner, global::Android.Widget.Spinner>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return DropDownHorizontalOffset;
				yield return DropDownVerticalOffset;
				yield return DropDownWidth;
				yield return PromptFormatted;
				yield return Prompt;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
