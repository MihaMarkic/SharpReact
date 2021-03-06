using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ToggleButton: CompoundButton
	{
		public ReactParam<global::Java.Lang.ICharSequence>? TextOffFormatted { get; set; }
		public ReactParam<global::System.String>? TextOff { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? TextOnFormatted { get; set; }
		public ReactParam<global::System.String>? TextOn { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ToggleButton<ToggleButton, global::Android.Widget.ToggleButton>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return TextOffFormatted;
				yield return TextOff;
				yield return TextOnFormatted;
				yield return TextOn;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
