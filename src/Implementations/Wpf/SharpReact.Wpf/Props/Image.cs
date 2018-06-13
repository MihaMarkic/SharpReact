using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Image: FrameworkElement
	{
		public ReactParam<global::System.Windows.Media.ImageSource>? Source { get; set; }
		public ReactParam<global::System.Windows.Media.Stretch>? Stretch { get; set; }
		public ReactParam<global::System.Windows.Controls.StretchDirection>? StretchDirection { get; set; }
		public System.EventHandler<global::System.Windows.ExceptionRoutedEventArgs> ImageFailed { get; set; }
		public System.Windows.DpiChangedEventHandler DpiChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Image<Image, System.Windows.Controls.Image>();
		}
	}
}
