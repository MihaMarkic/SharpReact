using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class NavigationWindow<TProps, TElement>: Window<TProps, TElement>
		where TProps : Props.NavigationWindow
		where TElement : global::System.Windows.Navigation.NavigationWindow, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.SandboxExternalContent.HasValue)
			{
				Element.SandboxExternalContent = nextProps.SandboxExternalContent.Value.Value;
			}
			if (nextProps.ShowsNavigationUI.HasValue)
			{
				Element.ShowsNavigationUI = nextProps.ShowsNavigationUI.Value.Value;
			}
			if (nextProps.Source.HasValue)
			{
				Element.Source = nextProps.Source.Value.Value;
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
