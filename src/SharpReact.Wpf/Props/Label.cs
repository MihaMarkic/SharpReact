using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Label: ContentControl
	{
		public ReactParam<System.Windows.UIElement>? Target { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Label<Label, System.Windows.Controls.Label>();
		}
	}
}
