using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class FrameworkElement<TProps, TElement>: UIElement<TProps, TElement>
		where TProps : Props.FrameworkElement
		where TElement : System.Windows.FrameworkElement, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Style.HasValue)
			{
				Element.Style = nextProps.Style.Value.Value;
			}
			if (nextProps.OverridesDefaultStyle.HasValue)
			{
				Element.OverridesDefaultStyle = nextProps.OverridesDefaultStyle.Value.Value;
			}
			if (nextProps.UseLayoutRounding.HasValue)
			{
				Element.UseLayoutRounding = nextProps.UseLayoutRounding.Value.Value;
			}
			if (nextProps.Resources.HasValue)
			{
				Element.Resources = nextProps.Resources.Value.Value;
			}
			if (nextProps.DataContext.HasValue)
			{
				Element.DataContext = nextProps.DataContext.Value.Value;
			}
			if (nextProps.BindingGroup.HasValue)
			{
				Element.BindingGroup = nextProps.BindingGroup.Value.Value;
			}
			if (nextProps.Language.HasValue)
			{
				Element.Language = nextProps.Language.Value.Value;
			}
			if (nextProps.Name.HasValue)
			{
				Element.Name = nextProps.Name.Value.Value;
			}
			if (nextProps.Tag.HasValue)
			{
				Element.Tag = nextProps.Tag.Value.Value;
			}
			if (nextProps.InputScope.HasValue)
			{
				Element.InputScope = nextProps.InputScope.Value.Value;
			}
			if (nextProps.LayoutTransform.HasValue)
			{
				Element.LayoutTransform = nextProps.LayoutTransform.Value.Value;
			}
			if (nextProps.Width.HasValue)
			{
				Element.Width = nextProps.Width.Value.Value;
			}
			if (nextProps.MinWidth.HasValue)
			{
				Element.MinWidth = nextProps.MinWidth.Value.Value;
			}
			if (nextProps.MaxWidth.HasValue)
			{
				Element.MaxWidth = nextProps.MaxWidth.Value.Value;
			}
			if (nextProps.Height.HasValue)
			{
				Element.Height = nextProps.Height.Value.Value;
			}
			if (nextProps.MinHeight.HasValue)
			{
				Element.MinHeight = nextProps.MinHeight.Value.Value;
			}
			if (nextProps.MaxHeight.HasValue)
			{
				Element.MaxHeight = nextProps.MaxHeight.Value.Value;
			}
			if (nextProps.FlowDirection.HasValue)
			{
				Element.FlowDirection = nextProps.FlowDirection.Value.Value;
			}
			if (nextProps.Margin.HasValue)
			{
				Element.Margin = nextProps.Margin.Value.Value;
			}
			if (nextProps.HorizontalAlignment.HasValue)
			{
				Element.HorizontalAlignment = nextProps.HorizontalAlignment.Value.Value;
			}
			if (nextProps.VerticalAlignment.HasValue)
			{
				Element.VerticalAlignment = nextProps.VerticalAlignment.Value.Value;
			}
			if (nextProps.FocusVisualStyle.HasValue)
			{
				Element.FocusVisualStyle = nextProps.FocusVisualStyle.Value.Value;
			}
			if (nextProps.Cursor.HasValue)
			{
				Element.Cursor = nextProps.Cursor.Value.Value;
			}
			if (nextProps.ForceCursor.HasValue)
			{
				Element.ForceCursor = nextProps.ForceCursor.Value.Value;
			}
			if (nextProps.ToolTip.HasValue)
			{
				Element.ToolTip = nextProps.ToolTip.Value.Value;
			}
			if (nextProps.ContextMenu.HasValue)
			{
				Element.ContextMenu = nextProps.ContextMenu.Value.Value;
			}
			if (!ReferenceEquals(Props?.TargetUpdated, null) && ReferenceEquals(nextProps.TargetUpdated, null))
			{
				Element.TargetUpdated -= nextProps.TargetUpdated;
			}
			if (ReferenceEquals(Props?.TargetUpdated, null) && !ReferenceEquals(nextProps.TargetUpdated, null))
			{
				Element.TargetUpdated += nextProps.TargetUpdated;
			}
			if (!ReferenceEquals(Props?.SourceUpdated, null) && ReferenceEquals(nextProps.SourceUpdated, null))
			{
				Element.SourceUpdated -= nextProps.SourceUpdated;
			}
			if (ReferenceEquals(Props?.SourceUpdated, null) && !ReferenceEquals(nextProps.SourceUpdated, null))
			{
				Element.SourceUpdated += nextProps.SourceUpdated;
			}
			if (!ReferenceEquals(Props?.DataContextChanged, null) && ReferenceEquals(nextProps.DataContextChanged, null))
			{
				Element.DataContextChanged -= nextProps.DataContextChanged;
			}
			if (ReferenceEquals(Props?.DataContextChanged, null) && !ReferenceEquals(nextProps.DataContextChanged, null))
			{
				Element.DataContextChanged += nextProps.DataContextChanged;
			}
			if (!ReferenceEquals(Props?.RequestBringIntoView, null) && ReferenceEquals(nextProps.RequestBringIntoView, null))
			{
				Element.RequestBringIntoView -= nextProps.RequestBringIntoView;
			}
			if (ReferenceEquals(Props?.RequestBringIntoView, null) && !ReferenceEquals(nextProps.RequestBringIntoView, null))
			{
				Element.RequestBringIntoView += nextProps.RequestBringIntoView;
			}
			if (!ReferenceEquals(Props?.SizeChanged, null) && ReferenceEquals(nextProps.SizeChanged, null))
			{
				Element.SizeChanged -= nextProps.SizeChanged;
			}
			if (ReferenceEquals(Props?.SizeChanged, null) && !ReferenceEquals(nextProps.SizeChanged, null))
			{
				Element.SizeChanged += nextProps.SizeChanged;
			}
			if (!ReferenceEquals(Props?.Initialized, null) && ReferenceEquals(nextProps.Initialized, null))
			{
				Element.Initialized -= nextProps.Initialized;
			}
			if (ReferenceEquals(Props?.Initialized, null) && !ReferenceEquals(nextProps.Initialized, null))
			{
				Element.Initialized += nextProps.Initialized;
			}
			if (!ReferenceEquals(Props?.Loaded, null) && ReferenceEquals(nextProps.Loaded, null))
			{
				Element.Loaded -= nextProps.Loaded;
			}
			if (ReferenceEquals(Props?.Loaded, null) && !ReferenceEquals(nextProps.Loaded, null))
			{
				Element.Loaded += nextProps.Loaded;
			}
			if (!ReferenceEquals(Props?.Unloaded, null) && ReferenceEquals(nextProps.Unloaded, null))
			{
				Element.Unloaded -= nextProps.Unloaded;
			}
			if (ReferenceEquals(Props?.Unloaded, null) && !ReferenceEquals(nextProps.Unloaded, null))
			{
				Element.Unloaded += nextProps.Unloaded;
			}
			if (!ReferenceEquals(Props?.ToolTipOpening, null) && ReferenceEquals(nextProps.ToolTipOpening, null))
			{
				Element.ToolTipOpening -= nextProps.ToolTipOpening;
			}
			if (ReferenceEquals(Props?.ToolTipOpening, null) && !ReferenceEquals(nextProps.ToolTipOpening, null))
			{
				Element.ToolTipOpening += nextProps.ToolTipOpening;
			}
			if (!ReferenceEquals(Props?.ToolTipClosing, null) && ReferenceEquals(nextProps.ToolTipClosing, null))
			{
				Element.ToolTipClosing -= nextProps.ToolTipClosing;
			}
			if (ReferenceEquals(Props?.ToolTipClosing, null) && !ReferenceEquals(nextProps.ToolTipClosing, null))
			{
				Element.ToolTipClosing += nextProps.ToolTipClosing;
			}
			if (!ReferenceEquals(Props?.ContextMenuOpening, null) && ReferenceEquals(nextProps.ContextMenuOpening, null))
			{
				Element.ContextMenuOpening -= nextProps.ContextMenuOpening;
			}
			if (ReferenceEquals(Props?.ContextMenuOpening, null) && !ReferenceEquals(nextProps.ContextMenuOpening, null))
			{
				Element.ContextMenuOpening += nextProps.ContextMenuOpening;
			}
			if (!ReferenceEquals(Props?.ContextMenuClosing, null) && ReferenceEquals(nextProps.ContextMenuClosing, null))
			{
				Element.ContextMenuClosing -= nextProps.ContextMenuClosing;
			}
			if (ReferenceEquals(Props?.ContextMenuClosing, null) && !ReferenceEquals(nextProps.ContextMenuClosing, null))
			{
				Element.ContextMenuClosing += nextProps.ContextMenuClosing;
			}
		}
	}
}
