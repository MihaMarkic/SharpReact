using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class FrameworkElement: UIElement
	{
		public ReactParam<System.Windows.Style>? Style { get; set; }
		public ReactParam<System.Boolean>? OverridesDefaultStyle { get; set; }
		public ReactParam<System.Boolean>? UseLayoutRounding { get; set; }
		public ReactParam<System.Windows.ResourceDictionary>? Resources { get; set; }
		public ReactParam<System.Object>? DataContext { get; set; }
		public ReactParam<System.Windows.Data.BindingGroup>? BindingGroup { get; set; }
		public ReactParam<System.Windows.Markup.XmlLanguage>? Language { get; set; }
		public ReactParam<System.String>? Name { get; set; }
		public ReactParam<System.Object>? Tag { get; set; }
		public ReactParam<System.Windows.Input.InputScope>? InputScope { get; set; }
		public ReactParam<System.Windows.Media.Transform>? LayoutTransform { get; set; }
		public ReactParam<System.Double>? Width { get; set; }
		public ReactParam<System.Double>? MinWidth { get; set; }
		public ReactParam<System.Double>? MaxWidth { get; set; }
		public ReactParam<System.Double>? Height { get; set; }
		public ReactParam<System.Double>? MinHeight { get; set; }
		public ReactParam<System.Double>? MaxHeight { get; set; }
		public ReactParam<System.Windows.FlowDirection>? FlowDirection { get; set; }
		public ReactParam<System.Windows.Thickness>? Margin { get; set; }
		public ReactParam<System.Windows.HorizontalAlignment>? HorizontalAlignment { get; set; }
		public ReactParam<System.Windows.VerticalAlignment>? VerticalAlignment { get; set; }
		public ReactParam<System.Windows.Style>? FocusVisualStyle { get; set; }
		public ReactParam<System.Windows.Input.Cursor>? Cursor { get; set; }
		public ReactParam<System.Boolean>? ForceCursor { get; set; }
		public ReactParam<System.Object>? ToolTip { get; set; }
		public ReactParam<System.Windows.Controls.ContextMenu>? ContextMenu { get; set; }
		public System.EventHandler<System.Windows.Data.DataTransferEventArgs> TargetUpdated { get; set; }
		public System.EventHandler<System.Windows.Data.DataTransferEventArgs> SourceUpdated { get; set; }
		public System.Windows.DependencyPropertyChangedEventHandler DataContextChanged { get; set; }
		public System.Windows.RequestBringIntoViewEventHandler RequestBringIntoView { get; set; }
		public System.Windows.SizeChangedEventHandler SizeChanged { get; set; }
		public System.EventHandler Initialized { get; set; }
		public System.Windows.RoutedEventHandler Loaded { get; set; }
		public System.Windows.RoutedEventHandler Unloaded { get; set; }
		public System.Windows.Controls.ToolTipEventHandler ToolTipOpening { get; set; }
		public System.Windows.Controls.ToolTipEventHandler ToolTipClosing { get; set; }
		public System.Windows.Controls.ContextMenuEventHandler ContextMenuOpening { get; set; }
		public System.Windows.Controls.ContextMenuEventHandler ContextMenuClosing { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FrameworkElement<FrameworkElement, System.Windows.FrameworkElement>();
		}
	}
}
