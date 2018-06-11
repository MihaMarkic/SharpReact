using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Frame<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.Frame
		where TElement : System.Windows.Controls.Frame, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Source.HasValue)
			{
				Element.Source = nextProps.Source.Value.Value;
			}
			if (nextProps.NavigationUIVisibility.HasValue)
			{
				Element.NavigationUIVisibility = nextProps.NavigationUIVisibility.Value.Value;
			}
			if (nextProps.SandboxExternalContent.HasValue)
			{
				Element.SandboxExternalContent = nextProps.SandboxExternalContent.Value.Value;
			}
			if (nextProps.JournalOwnership.HasValue)
			{
				Element.JournalOwnership = nextProps.JournalOwnership.Value.Value;
			}
			if (!ReferenceEquals(previous?.ContentRendered, null) && ReferenceEquals(nextProps.ContentRendered, null))
			{
				Element.ContentRendered -= nextProps.ContentRendered;
			}
			if (ReferenceEquals(previous?.ContentRendered, null) && !ReferenceEquals(nextProps.ContentRendered, null))
			{
				Element.ContentRendered += nextProps.ContentRendered;
			}
			if (!ReferenceEquals(previous?.Navigating, null) && ReferenceEquals(nextProps.Navigating, null))
			{
				Element.Navigating -= nextProps.Navigating;
			}
			if (ReferenceEquals(previous?.Navigating, null) && !ReferenceEquals(nextProps.Navigating, null))
			{
				Element.Navigating += nextProps.Navigating;
			}
			if (!ReferenceEquals(previous?.NavigationProgress, null) && ReferenceEquals(nextProps.NavigationProgress, null))
			{
				Element.NavigationProgress -= nextProps.NavigationProgress;
			}
			if (ReferenceEquals(previous?.NavigationProgress, null) && !ReferenceEquals(nextProps.NavigationProgress, null))
			{
				Element.NavigationProgress += nextProps.NavigationProgress;
			}
			if (!ReferenceEquals(previous?.NavigationFailed, null) && ReferenceEquals(nextProps.NavigationFailed, null))
			{
				Element.NavigationFailed -= nextProps.NavigationFailed;
			}
			if (ReferenceEquals(previous?.NavigationFailed, null) && !ReferenceEquals(nextProps.NavigationFailed, null))
			{
				Element.NavigationFailed += nextProps.NavigationFailed;
			}
			if (!ReferenceEquals(previous?.Navigated, null) && ReferenceEquals(nextProps.Navigated, null))
			{
				Element.Navigated -= nextProps.Navigated;
			}
			if (ReferenceEquals(previous?.Navigated, null) && !ReferenceEquals(nextProps.Navigated, null))
			{
				Element.Navigated += nextProps.Navigated;
			}
			if (!ReferenceEquals(previous?.LoadCompleted, null) && ReferenceEquals(nextProps.LoadCompleted, null))
			{
				Element.LoadCompleted -= nextProps.LoadCompleted;
			}
			if (ReferenceEquals(previous?.LoadCompleted, null) && !ReferenceEquals(nextProps.LoadCompleted, null))
			{
				Element.LoadCompleted += nextProps.LoadCompleted;
			}
			if (!ReferenceEquals(previous?.NavigationStopped, null) && ReferenceEquals(nextProps.NavigationStopped, null))
			{
				Element.NavigationStopped -= nextProps.NavigationStopped;
			}
			if (ReferenceEquals(previous?.NavigationStopped, null) && !ReferenceEquals(nextProps.NavigationStopped, null))
			{
				Element.NavigationStopped += nextProps.NavigationStopped;
			}
			if (!ReferenceEquals(previous?.FragmentNavigation, null) && ReferenceEquals(nextProps.FragmentNavigation, null))
			{
				Element.FragmentNavigation -= nextProps.FragmentNavigation;
			}
			if (ReferenceEquals(previous?.FragmentNavigation, null) && !ReferenceEquals(nextProps.FragmentNavigation, null))
			{
				Element.FragmentNavigation += nextProps.FragmentNavigation;
			}
		}
	}
}
