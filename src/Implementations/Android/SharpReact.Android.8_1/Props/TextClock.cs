using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class TextClock: TextView
	{
		public ReactParam<global::Java.Lang.ICharSequence>? Format12HourFormatted { get; set; }
		public ReactParam<global::System.String>? Format12Hour { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? Format24HourFormatted { get; set; }
		public ReactParam<global::System.String>? Format24Hour { get; set; }
		public ReactParam<global::System.String>? TimeZone { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TextClock<TextClock, global::Android.Widget.TextClock>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Format12HourFormatted;
				yield return Format12Hour;
				yield return Format24HourFormatted;
				yield return Format24Hour;
				yield return TimeZone;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
