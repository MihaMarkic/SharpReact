using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class AdornedElementPlaceholder: FrameworkElement
	{
		public ReactParam<System.Windows.UIElement>? Child { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AdornedElementPlaceholder<AdornedElementPlaceholder, System.Windows.Controls.AdornedElementPlaceholder>();
		}
	}
}
