using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ListBox: Selector
	{
		public ReactParam<System.Windows.Controls.SelectionMode>? SelectionMode { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ListBox<ListBox, System.Windows.Controls.ListBox>();
		}
	}
}
