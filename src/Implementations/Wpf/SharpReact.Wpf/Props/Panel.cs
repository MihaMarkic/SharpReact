using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class Panel: FrameworkElement
	{
		public ReactParam<global::System.Windows.Media.Brush>? Background { get; set; }
		public List<ISharpProp> Children { get; set; } = new List<ISharpProp>();
		public ReactParam<global::System.Boolean>? IsItemsHost { get; set; }
		protected override void UnmountComponent()
		{
			UnmountComponents(Children);
			base.UnmountComponent();
		}
	}
}
