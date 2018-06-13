using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ComboBoxItem: ListBoxItem
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ComboBoxItem<ComboBoxItem, System.Windows.Controls.ComboBoxItem>();
		}
	}
}
