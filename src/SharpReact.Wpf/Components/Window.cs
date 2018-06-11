using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Window<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.Window
		where TElement : System.Windows.Window, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.TaskbarItemInfo.HasValue)
			{
				Element.TaskbarItemInfo = nextProps.TaskbarItemInfo.Value.Value;
			}
			if (nextProps.AllowsTransparency.HasValue)
			{
				Element.AllowsTransparency = nextProps.AllowsTransparency.Value.Value;
			}
			if (nextProps.Title.HasValue)
			{
				Element.Title = nextProps.Title.Value.Value;
			}
			if (nextProps.Icon.HasValue)
			{
				Element.Icon = nextProps.Icon.Value.Value;
			}
			if (nextProps.SizeToContent.HasValue)
			{
				Element.SizeToContent = nextProps.SizeToContent.Value.Value;
			}
			if (nextProps.Top.HasValue)
			{
				Element.Top = nextProps.Top.Value.Value;
			}
			if (nextProps.Left.HasValue)
			{
				Element.Left = nextProps.Left.Value.Value;
			}
			if (nextProps.WindowStartupLocation.HasValue)
			{
				Element.WindowStartupLocation = nextProps.WindowStartupLocation.Value.Value;
			}
			if (nextProps.ShowInTaskbar.HasValue)
			{
				Element.ShowInTaskbar = nextProps.ShowInTaskbar.Value.Value;
			}
			if (nextProps.Owner.HasValue)
			{
				Element.Owner = nextProps.Owner.Value.Value;
			}
			if (nextProps.DialogResult.HasValue)
			{
				Element.DialogResult = nextProps.DialogResult.Value.Value;
			}
			if (nextProps.WindowStyle.HasValue)
			{
				Element.WindowStyle = nextProps.WindowStyle.Value.Value;
			}
			if (nextProps.WindowState.HasValue)
			{
				Element.WindowState = nextProps.WindowState.Value.Value;
			}
			if (nextProps.ResizeMode.HasValue)
			{
				Element.ResizeMode = nextProps.ResizeMode.Value.Value;
			}
			if (nextProps.Topmost.HasValue)
			{
				Element.Topmost = nextProps.Topmost.Value.Value;
			}
			if (nextProps.ShowActivated.HasValue)
			{
				Element.ShowActivated = nextProps.ShowActivated.Value.Value;
			}
			if (!ReferenceEquals(previous?.SourceInitialized, null) && ReferenceEquals(nextProps.SourceInitialized, null))
			{
				Element.SourceInitialized -= nextProps.SourceInitialized;
			}
			if (ReferenceEquals(previous?.SourceInitialized, null) && !ReferenceEquals(nextProps.SourceInitialized, null))
			{
				Element.SourceInitialized += nextProps.SourceInitialized;
			}
			if (!ReferenceEquals(previous?.DpiChanged, null) && ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged -= nextProps.DpiChanged;
			}
			if (ReferenceEquals(previous?.DpiChanged, null) && !ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged += nextProps.DpiChanged;
			}
			if (!ReferenceEquals(previous?.Activated, null) && ReferenceEquals(nextProps.Activated, null))
			{
				Element.Activated -= nextProps.Activated;
			}
			if (ReferenceEquals(previous?.Activated, null) && !ReferenceEquals(nextProps.Activated, null))
			{
				Element.Activated += nextProps.Activated;
			}
			if (!ReferenceEquals(previous?.Deactivated, null) && ReferenceEquals(nextProps.Deactivated, null))
			{
				Element.Deactivated -= nextProps.Deactivated;
			}
			if (ReferenceEquals(previous?.Deactivated, null) && !ReferenceEquals(nextProps.Deactivated, null))
			{
				Element.Deactivated += nextProps.Deactivated;
			}
			if (!ReferenceEquals(previous?.StateChanged, null) && ReferenceEquals(nextProps.StateChanged, null))
			{
				Element.StateChanged -= nextProps.StateChanged;
			}
			if (ReferenceEquals(previous?.StateChanged, null) && !ReferenceEquals(nextProps.StateChanged, null))
			{
				Element.StateChanged += nextProps.StateChanged;
			}
			if (!ReferenceEquals(previous?.LocationChanged, null) && ReferenceEquals(nextProps.LocationChanged, null))
			{
				Element.LocationChanged -= nextProps.LocationChanged;
			}
			if (ReferenceEquals(previous?.LocationChanged, null) && !ReferenceEquals(nextProps.LocationChanged, null))
			{
				Element.LocationChanged += nextProps.LocationChanged;
			}
			if (!ReferenceEquals(previous?.Closing, null) && ReferenceEquals(nextProps.Closing, null))
			{
				Element.Closing -= nextProps.Closing;
			}
			if (ReferenceEquals(previous?.Closing, null) && !ReferenceEquals(nextProps.Closing, null))
			{
				Element.Closing += nextProps.Closing;
			}
			if (!ReferenceEquals(previous?.Closed, null) && ReferenceEquals(nextProps.Closed, null))
			{
				Element.Closed -= nextProps.Closed;
			}
			if (ReferenceEquals(previous?.Closed, null) && !ReferenceEquals(nextProps.Closed, null))
			{
				Element.Closed += nextProps.Closed;
			}
			if (!ReferenceEquals(previous?.ContentRendered, null) && ReferenceEquals(nextProps.ContentRendered, null))
			{
				Element.ContentRendered -= nextProps.ContentRendered;
			}
			if (ReferenceEquals(previous?.ContentRendered, null) && !ReferenceEquals(nextProps.ContentRendered, null))
			{
				Element.ContentRendered += nextProps.ContentRendered;
			}
		}
	}
}
