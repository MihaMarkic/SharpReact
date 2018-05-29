using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class GroupBox: HeaderedContentControl
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GroupBox<GroupBox, System.Windows.Controls.GroupBox>();
		}
	}
}
