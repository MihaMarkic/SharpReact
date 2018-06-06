using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Page: FrameworkElement
	{
		public ISharpProp Content { get; set; }
		public ReactParam<System.String>? WindowTitle { get; set; }
		public ReactParam<System.Double>? WindowHeight { get; set; }
		public ReactParam<System.Double>? WindowWidth { get; set; }
		public ReactParam<System.Windows.Media.Brush>? Background { get; set; }
		public ReactParam<System.String>? Title { get; set; }
		public ReactParam<System.Boolean>? ShowsNavigationUI { get; set; }
		public ReactParam<System.Boolean>? KeepAlive { get; set; }
		public ReactParam<System.Windows.Media.Brush>? Foreground { get; set; }
		public ReactParam<System.Windows.Media.FontFamily>? FontFamily { get; set; }
		public ReactParam<System.Double>? FontSize { get; set; }
		public ReactParam<System.Windows.Controls.ControlTemplate>? Template { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Page<Page, System.Windows.Controls.Page>();
		}
		protected override void UnmountComponent()
		{
			UnmountComponent(Content);
			base.UnmountComponent();
		}
	}
}
