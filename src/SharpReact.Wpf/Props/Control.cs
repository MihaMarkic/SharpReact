using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Control: FrameworkElement
	{
		public ReactParam<System.Windows.Media.Brush>? BorderBrush { get; set; }
		public ReactParam<System.Windows.Thickness>? BorderThickness { get; set; }
		public ReactParam<System.Windows.Media.Brush>? Background { get; set; }
		public ReactParam<System.Windows.Media.Brush>? Foreground { get; set; }
		public ReactParam<System.Windows.Media.FontFamily>? FontFamily { get; set; }
		public ReactParam<System.Double>? FontSize { get; set; }
		public ReactParam<System.Windows.FontStretch>? FontStretch { get; set; }
		public ReactParam<System.Windows.FontStyle>? FontStyle { get; set; }
		public ReactParam<System.Windows.FontWeight>? FontWeight { get; set; }
		public ReactParam<System.Windows.HorizontalAlignment>? HorizontalContentAlignment { get; set; }
		public ReactParam<System.Windows.VerticalAlignment>? VerticalContentAlignment { get; set; }
		public ReactParam<System.Int32>? TabIndex { get; set; }
		public ReactParam<System.Boolean>? IsTabStop { get; set; }
		public ReactParam<System.Windows.Thickness>? Padding { get; set; }
		public ReactParam<System.Windows.Controls.ControlTemplate>? Template { get; set; }
		public System.Windows.Input.MouseButtonEventHandler PreviewMouseDoubleClick { get; set; }
		public System.Windows.Input.MouseButtonEventHandler MouseDoubleClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Control<Control, System.Windows.Controls.Control>();
		}
	}
}
