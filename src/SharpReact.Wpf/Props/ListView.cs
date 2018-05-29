using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ListView: ListBox
	{
		public ReactParam<System.Windows.Controls.ViewBase>? View { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ListView<ListView, System.Windows.Controls.ListView>();
		}
	}
}
