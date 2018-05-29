using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class GroupItem: ContentControl
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GroupItem<GroupItem, System.Windows.Controls.GroupItem>();
		}
	}
}
