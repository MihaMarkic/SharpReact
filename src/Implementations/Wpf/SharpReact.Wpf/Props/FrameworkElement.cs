using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class FrameworkElement: UIElement
	{
		public ReactParam<global::System.Windows.Style>? Style { get; set; }
		public ReactParam<global::System.Boolean>? OverridesDefaultStyle { get; set; }
		public ReactParam<global::System.Boolean>? UseLayoutRounding { get; set; }
		public ReactParam<global::System.Windows.ResourceDictionary>? Resources { get; set; }
		public ReactParam<global::System.Object>? DataContext { get; set; }
		public ReactParam<global::System.Windows.Data.BindingGroup>? BindingGroup { get; set; }
		public ReactParam<global::System.Windows.Markup.XmlLanguage>? Language { get; set; }
		public ReactParam<global::System.String>? Name { get; set; }
		public ReactParam<global::System.Object>? Tag { get; set; }
		public ReactParam<global::System.Windows.Input.InputScope>? InputScope { get; set; }
		public ReactParam<global::System.Windows.Media.Transform>? LayoutTransform { get; set; }
		public ReactParam<global::System.Double>? Width { get; set; }
		public ReactParam<global::System.Double>? MinWidth { get; set; }
		public ReactParam<global::System.Double>? MaxWidth { get; set; }
		public ReactParam<global::System.Double>? Height { get; set; }
		public ReactParam<global::System.Double>? MinHeight { get; set; }
		public ReactParam<global::System.Double>? MaxHeight { get; set; }
		public ReactParam<global::System.Windows.FlowDirection>? FlowDirection { get; set; }
		public ReactParam<global::System.Windows.Thickness>? Margin { get; set; }
		public ReactParam<global::System.Windows.HorizontalAlignment>? HorizontalAlignment { get; set; }
		public ReactParam<global::System.Windows.VerticalAlignment>? VerticalAlignment { get; set; }
		public ReactParam<global::System.Windows.Style>? FocusVisualStyle { get; set; }
		public ReactParam<global::System.Windows.Input.Cursor>? Cursor { get; set; }
		public ReactParam<global::System.Boolean>? ForceCursor { get; set; }
		public ReactParam<global::System.Object>? ToolTip { get; set; }
		public ReactParam<global::System.Windows.Controls.ContextMenu>? ContextMenu { get; set; }
		public System.EventHandler<global::System.Windows.Data.DataTransferEventArgs> TargetUpdated { get; set; }
		public System.EventHandler<global::System.Windows.Data.DataTransferEventArgs> SourceUpdated { get; set; }
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
