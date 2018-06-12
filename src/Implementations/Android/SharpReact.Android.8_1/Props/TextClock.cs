using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class TextClock: TextView
	{
		public ReactParam<global::Java.Lang.ICharSequence>? Format12HourFormatted { get; set; }
		public ReactParam<global::System.String>? Format12Hour { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? Format24HourFormatted { get; set; }
		public ReactParam<global::System.String>? Format24Hour { get; set; }
		public ReactParam<global::System.String>? TimeZone { get; set; }
	}
}
