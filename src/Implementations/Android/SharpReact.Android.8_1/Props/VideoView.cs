using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class VideoView: SurfaceView
	{
		public System.EventHandler Completion { get; set; }
		public System.EventHandler<global::Android.Media.MediaPlayer.ErrorEventArgs> Error { get; set; }
		public System.EventHandler<global::Android.Media.MediaPlayer.InfoEventArgs> Info { get; set; }
		public System.EventHandler Prepared { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.VideoView<VideoView, global::Android.Widget.VideoView>();
		}
	}
}
