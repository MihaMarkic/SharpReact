using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Decorator: FrameworkElement
	{
		public ReactParam<global::System.Windows.UIElement>? Child { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Decorator<Decorator, System.Windows.Controls.Decorator>();
		}
	}
}
