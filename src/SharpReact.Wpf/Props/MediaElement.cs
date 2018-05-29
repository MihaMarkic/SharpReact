using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class MediaElement: FrameworkElement
	{
		public ReactParam<System.Uri>? Source { get; set; }
		public ReactParam<System.Windows.Media.MediaClock>? Clock { get; set; }
		public ReactParam<System.Windows.Media.Stretch>? Stretch { get; set; }
		public ReactParam<System.Windows.Controls.StretchDirection>? StretchDirection { get; set; }
		public ReactParam<System.Double>? Volume { get; set; }
		public ReactParam<System.Double>? Balance { get; set; }
		public ReactParam<System.Boolean>? IsMuted { get; set; }
		public ReactParam<System.Boolean>? ScrubbingEnabled { get; set; }
		public ReactParam<System.Windows.Controls.MediaState>? UnloadedBehavior { get; set; }
		public ReactParam<System.Windows.Controls.MediaState>? LoadedBehavior { get; set; }
		public ReactParam<System.TimeSpan>? Position { get; set; }
		public ReactParam<System.Double>? SpeedRatio { get; set; }
		public System.EventHandler<System.Windows.ExceptionRoutedEventArgs> MediaFailed { get; set; }
		public System.Windows.RoutedEventHandler MediaOpened { get; set; }
		public System.Windows.RoutedEventHandler BufferingStarted { get; set; }
		public System.Windows.RoutedEventHandler BufferingEnded { get; set; }
		public System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs> ScriptCommand { get; set; }
		public System.Windows.RoutedEventHandler MediaEnded { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.MediaElement<MediaElement, System.Windows.Controls.MediaElement>();
		}
	}
}
