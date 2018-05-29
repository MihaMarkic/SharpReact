using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Button: ButtonBase
	{
		public ReactParam<System.Boolean>? IsDefault { get; set; }
		public ReactParam<System.Boolean>? IsCancel { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Button<Button, System.Windows.Controls.Button>();
		}
	}
}
