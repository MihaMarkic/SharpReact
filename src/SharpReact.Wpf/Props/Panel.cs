using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class Panel: FrameworkElement, IChildrenContainer
	{
		public ReactParam<System.Windows.Media.Brush>? Background { get; set; }
		public List<ISharpProp> Children { get; set; } = new List<ISharpProp>();
		IList<ISharpProp> IChildrenContainer.Children => Children;
		public ReactParam<System.Boolean>? IsItemsHost { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			throw new System.NotImplementedException();
		}
	}
}
