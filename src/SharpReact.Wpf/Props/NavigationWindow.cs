using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class NavigationWindow: Window
	{
		public ReactParam<System.Boolean>? SandboxExternalContent { get; set; }
		public ReactParam<System.Boolean>? ShowsNavigationUI { get; set; }
		public ReactParam<System.Uri>? Source { get; set; }
		public System.Windows.Navigation.NavigatingCancelEventHandler Navigating { get; set; }
		public System.Windows.Navigation.NavigationProgressEventHandler NavigationProgress { get; set; }
		public System.Windows.Navigation.NavigationFailedEventHandler NavigationFailed { get; set; }
		public System.Windows.Navigation.NavigatedEventHandler Navigated { get; set; }
		public System.Windows.Navigation.LoadCompletedEventHandler LoadCompleted { get; set; }
		public System.Windows.Navigation.NavigationStoppedEventHandler NavigationStopped { get; set; }
		public System.Windows.Navigation.FragmentNavigationEventHandler FragmentNavigation { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.NavigationWindow<NavigationWindow, System.Windows.Navigation.NavigationWindow>();
		}
	}
}
