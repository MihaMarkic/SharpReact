using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class SeekBar: AbsSeekBar
	{
		public System.EventHandler<global::Android.Widget.SeekBar.ProgressChangedEventArgs> ProgressChanged { get; set; }
		public System.EventHandler<global::Android.Widget.SeekBar.StartTrackingTouchEventArgs> StartTrackingTouch { get; set; }
		public System.EventHandler<global::Android.Widget.SeekBar.StopTrackingTouchEventArgs> StopTrackingTouch { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.SeekBar<SeekBar, global::Android.Widget.SeekBar>();
		}
	}
}
