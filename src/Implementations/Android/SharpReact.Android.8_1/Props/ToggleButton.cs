using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class ToggleButton: CompoundButton
	{
		public ReactParam<global::Java.Lang.ICharSequence>? TextOffFormatted { get; set; }
		public ReactParam<global::System.String>? TextOff { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? TextOnFormatted { get; set; }
		public ReactParam<global::System.String>? TextOn { get; set; }
	}
}
