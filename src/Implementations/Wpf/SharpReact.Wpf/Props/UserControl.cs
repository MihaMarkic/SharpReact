using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class UserControl: ContentControl
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.UserControl<UserControl, System.Windows.Controls.UserControl>();
		}
	}
}
