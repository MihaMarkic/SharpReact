using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Menu: MenuBase
	{
		public ReactParam<System.Boolean>? IsMainMenu { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Menu<Menu, System.Windows.Controls.Menu>();
		}
	}
}
