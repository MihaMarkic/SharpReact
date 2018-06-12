using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class Chronometer: TextView
	{
		public ReactParam<global::System.Int64>? Base { get; set; }
		public ReactParam<global::System.Boolean>? CountDown { get; set; }
		public ReactParam<global::System.String>? Format { get; set; }
		public ReactParam<global::Android.Widget.Chronometer.IOnChronometerTickListener>? OnChronometerTickListener { get; set; }
		public System.EventHandler ChronometerTick { get; set; }
	}
}
