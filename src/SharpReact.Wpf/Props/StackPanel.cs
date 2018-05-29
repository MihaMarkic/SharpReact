using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class StackPanel: Panel
	{
		public ReactParam<System.Windows.Controls.Orientation>? Orientation { get; set; }
		public ReactParam<System.Boolean>? CanHorizontallyScroll { get; set; }
		public ReactParam<System.Boolean>? CanVerticallyScroll { get; set; }
		public ReactParam<System.Windows.Controls.ScrollViewer>? ScrollOwner { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.StackPanel<StackPanel, System.Windows.Controls.StackPanel>();
		}
	}
}
