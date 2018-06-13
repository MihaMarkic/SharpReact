using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class WebBrowser: ActiveXHost
	{
		public ReactParam<global::System.Uri>? Source { get; set; }
		public ReactParam<global::System.Object>? ObjectForScripting { get; set; }
		public System.Windows.Navigation.NavigatingCancelEventHandler Navigating { get; set; }
		public System.Windows.Navigation.NavigatedEventHandler Navigated { get; set; }
		public System.Windows.Navigation.LoadCompletedEventHandler LoadCompleted { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.WebBrowser<WebBrowser>();
		}
	}
}
