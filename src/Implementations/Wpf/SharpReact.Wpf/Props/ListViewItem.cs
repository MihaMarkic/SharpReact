using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ListViewItem: ListBoxItem
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ListViewItem<ListViewItem, System.Windows.Controls.ListViewItem>();
		}
	}
}
