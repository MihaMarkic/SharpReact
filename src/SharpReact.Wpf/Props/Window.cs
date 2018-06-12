using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Window: ContentControl
	{
		public ReactParam<global::System.Windows.Shell.TaskbarItemInfo>? TaskbarItemInfo { get; set; }
		public ReactParam<global::System.Boolean>? AllowsTransparency { get; set; }
		public ReactParam<global::System.String>? Title { get; set; }
		public ReactParam<global::System.Windows.Media.ImageSource>? Icon { get; set; }
		public ReactParam<global::System.Windows.SizeToContent>? SizeToContent { get; set; }
		public ReactParam<global::System.Double>? Top { get; set; }
		public ReactParam<global::System.Double>? Left { get; set; }
		public ReactParam<global::System.Windows.WindowStartupLocation>? WindowStartupLocation { get; set; }
		public ReactParam<global::System.Boolean>? ShowInTaskbar { get; set; }
		public ReactParam<global::System.Windows.Window>? Owner { get; set; }
		public ReactParam<global::System.Nullable<System.Boolean>>? DialogResult { get; set; }
		public ReactParam<global::System.Windows.WindowStyle>? WindowStyle { get; set; }
		public ReactParam<global::System.Windows.WindowState>? WindowState { get; set; }
		public ReactParam<global::System.Windows.ResizeMode>? ResizeMode { get; set; }
		public ReactParam<global::System.Boolean>? Topmost { get; set; }
		public ReactParam<global::System.Boolean>? ShowActivated { get; set; }
		public System.EventHandler SourceInitialized { get; set; }
		public System.Windows.DpiChangedEventHandler DpiChanged { get; set; }
		public System.EventHandler Activated { get; set; }
		public System.EventHandler Deactivated { get; set; }
		public System.EventHandler StateChanged { get; set; }
		public System.EventHandler LocationChanged { get; set; }
		public System.ComponentModel.CancelEventHandler Closing { get; set; }
		public System.EventHandler Closed { get; set; }
		public System.EventHandler ContentRendered { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Window<Window, System.Windows.Window>();
		}
	}
}
