using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Frame: ContentControl
	{
		public ReactParam<System.Uri>? Source { get; set; }
		public ReactParam<System.Windows.Navigation.NavigationUIVisibility>? NavigationUIVisibility { get; set; }
		public ReactParam<System.Boolean>? SandboxExternalContent { get; set; }
		public ReactParam<System.Windows.Navigation.JournalOwnership>? JournalOwnership { get; set; }
		public System.EventHandler ContentRendered { get; set; }
		public System.Windows.Navigation.NavigatingCancelEventHandler Navigating { get; set; }
		public System.Windows.Navigation.NavigationProgressEventHandler NavigationProgress { get; set; }
		public System.Windows.Navigation.NavigationFailedEventHandler NavigationFailed { get; set; }
		public System.Windows.Navigation.NavigatedEventHandler Navigated { get; set; }
		public System.Windows.Navigation.LoadCompletedEventHandler LoadCompleted { get; set; }
		public System.Windows.Navigation.NavigationStoppedEventHandler NavigationStopped { get; set; }
		public System.Windows.Navigation.FragmentNavigationEventHandler FragmentNavigation { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Frame<Frame, System.Windows.Controls.Frame>();
		}
	}
}
